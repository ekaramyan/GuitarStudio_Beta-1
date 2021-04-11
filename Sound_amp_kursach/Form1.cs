using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSCore;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using CSCore.SoundOut;
using CSCore.Streams;
using CSCore.Streams.Effects;
using System.Collections.ObjectModel;
using System.Diagnostics;
using CSCore.Codecs;




namespace Sound_amp_kursach
{

    public partial class Form1 : Form
    {
        private readonly Player _Player = new Player();
        private bool _stopSliderUpdate;
        private readonly ObservableCollection<MMDevice> _devices = new ObservableCollection<MMDevice>();
        public Form1()
        {
            InitializeComponent();
            components = new Container();
            components.Add(_Player);
            _Player.PlaybackStopped += (s, args) =>
            {
                //WasapiOut uses SynchronizationContext.Post to raise the event
                //There might be already a new WasapiOut-instance in the background when the async Post method brings the PlaybackStopped-Event to us.
                if (_Player.PlaybackState != PlaybackState.Stopped)
                    Play_button.Enabled = Stop_button.Enabled = Pause_button.Enabled = false;
            };
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //PlayInputDevice play = new PlayInputDevice();
            using (var mmdeviceEnumerator = new MMDeviceEnumerator())
            {
                using (
                    var mmdeviceCollection = mmdeviceEnumerator.EnumAudioEndpoints(DataFlow.Render, DeviceState.Active))
                {
                    foreach (var device in mmdeviceCollection)
                    {
                        _devices.Add(device);
                    }
                }
            }

            comboBox1.DataSource = _devices;
            comboBox1.DisplayMember = "FriendlyName";
            comboBox1.ValueMember = "DeviceID";
        }
        /*
        private void Live_play_Click(object sender, EventArgs e)
        {
           using (var soundIn = new WasapiCapture(true, AudioClientShareMode.Shared, 30))
            {
                soundIn.Initialize();
                IWaveSource source = new SoundInSource(soundIn) { FillWithZeros = true };
                using (var echoSource = new DmoEchoEffect(source))
                {
                    soundIn.Start();
                    using (var soundOut = new WasapiOut())
                    {
                        soundOut.Initialize(echoSource);
                        soundOut.Play();
                    }
                }
            }
        }*/
        private void Volume_bar_ValueChanged(object sender, EventArgs e)
        {
            _Player.Volume = volume_bar.Value;
        }

        private void Play_button_Click(object sender, EventArgs e)
        {
                if (_Player.PlaybackState != PlaybackState.Playing)
                {
                    _Player.Play();
                    Play_button.Enabled = false;
                    Pause_button.Enabled = Stop_button.Enabled = true;
                }
        }

        private void Stop_button_Click(object sender, EventArgs e)
        {
            if (_Player.PlaybackState != PlaybackState.Stopped)
            {
                _Player.Stop();
                Play_button.Enabled = Stop_button.Enabled = Pause_button.Enabled = false;
            }
        }

        private void Pause_button_Click(object sender, EventArgs e)
        {
            if (_Player.PlaybackState == PlaybackState.Playing)
            {
                _Player.Pause();
                Pause_button.Enabled = false;
                Play_button.Enabled = Stop_button.Enabled = true;
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = CodecFactory.SupportedFilesFilterEn
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _Player.Open(openFileDialog.FileName, (MMDevice)comboBox1.SelectedItem);
                    volume_bar.Value = _Player.Volume;

                    Play_button.Enabled = true;
                    Pause_button.Enabled = Stop_button.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not open file: " + ex.Message);
                }
            }
        }
        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _stopSliderUpdate = true;
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _stopSliderUpdate = false;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (_stopSliderUpdate)
            {
                double perc = trackBar1.Value / (double)trackBar1.Maximum;
                TimeSpan position = TimeSpan.FromMilliseconds(_Player.Length.TotalMilliseconds * perc);
                _Player.Position = position;
            }
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            TimeSpan position = _Player.Position;
            TimeSpan length = _Player.Length;
            if (position > length)
                length = position;

            lblPosition.Text = String.Format(@"{0:mm\:ss} / {1:mm\:ss}", position, length);

            if (!_stopSliderUpdate &&
                length != TimeSpan.Zero && position != TimeSpan.Zero)
            {
                double perc = position.TotalMilliseconds / length.TotalMilliseconds * trackBar1.Maximum;
                trackBar1.Value = (int)perc;
            }
        }

        private void LblPosition_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
