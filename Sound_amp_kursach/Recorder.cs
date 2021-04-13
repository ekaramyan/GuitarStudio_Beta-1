using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;
using CSCore;
using CSCore.Codecs.WAV;
using CSCore.CoreAudioAPI;
using System.Windows.Forms;
using CSCore.SoundIn;
using CSCore.Streams;
using CSCore.Win32;

namespace Sound_amp_kursach
{
    public partial class Recorder : Form
    {
        //Change this to CaptureMode.Capture to capture a microphone,...
        private const CaptureMode CaptureMode = Sound_amp_kursach.CaptureMode.Capture;

        private MMDevice _selectedDevice;
        private WasapiCapture _soundIn;
        private IWriteable _writer;
        //private readonly GraphVisualization _graphVisualization = new GraphVisualization();
        private IWaveSource _finalSource;

        public MMDevice SelectedDevice
        {
            get { return _selectedDevice; }
            set
            {
                _selectedDevice = value;
                if (value != null)
                    btnStart.Enabled = true;
            }
        }

        public static CaptureMode CaptureMode1 => CaptureMode2;

        public static CaptureMode CaptureMode2 => CaptureMode;

        public Recorder()
        {
            InitializeComponent();
        }

        private void RefreshDevices()
        {
            deviceList.Items.Clear();

            using (var deviceEnumerator = new MMDeviceEnumerator())
            using (var deviceCollection = deviceEnumerator.EnumAudioEndpoints(
                CaptureMode2 == CaptureMode.Capture ? DataFlow.Capture : DataFlow.Render, DeviceState.Active))
            {
                foreach (var device in deviceCollection)
                {
                    var deviceFormat = WaveFormatFromBlob(device.PropertyStore[
                        new PropertyKey(new Guid(0xf19f064d, 0x82c, 0x4e27, 0xbc, 0x73, 0x68, 0x82, 0xa1, 0xbb, 0x8e, 0x4c), 0)].BlobValue);

                    var item = new ListViewItem(device.FriendlyName) { Tag = device };
                    item.SubItems.Add(deviceFormat.Channels.ToString(CultureInfo.InvariantCulture));

                    deviceList.Items.Add(item);
                }
            }
        }
        private void StartCapture(string fileName)
        {
            if (SelectedDevice == null)
                return;

            if (CaptureMode2 == CaptureMode.Capture)
                _soundIn = new WasapiCapture();
            else
                _soundIn = new WasapiLoopbackCapture();

            _soundIn.Device = SelectedDevice;
            _soundIn.Initialize();

            var soundInSource = new SoundInSource(_soundIn);
            var singleBlockNotificationStream = new SingleBlockNotificationStream(soundInSource.ToSampleSource());
            _finalSource = singleBlockNotificationStream.ToWaveSource();
            _writer = new WaveWriter(fileName, _finalSource.WaveFormat);

            byte[] buffer = new byte[_finalSource.WaveFormat.BytesPerSecond / 2];
            soundInSource.DataAvailable += (s, e) =>
            {
                int read;
                while ((read = _finalSource.Read(buffer, 0, buffer.Length)) > 0)
                    _writer.Write(buffer, 0, read);
            };

            //singleBlockNotificationStream.SingleBlockRead += SingleBlockNotificationStreamOnSingleBlockRead;

            _soundIn.Start();
        }

        private static WaveFormat WaveFormatFromBlob(Blob blob)
        {
            if (blob.Length == 40)
                return (WaveFormat)Marshal.PtrToStructure(blob.Data, typeof(WaveFormatExtensible));
            return (WaveFormat)Marshal.PtrToStructure(blob.Data, typeof(WaveFormat));
        }

        private void btnRefreshDevices_Click(object sender, EventArgs e)
        {
            RefreshDevices();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "WAV (*.wav)|*.wav",
                Title = "Save",
                FileName = String.Empty
            };
            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                StartCapture(sfd.FileName);
                btnStart.Enabled = false;
                btnStop.Enabled = true;
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            StopCapture();
        }
        private void StopCapture()
        {
            if (_soundIn != null)
            {
                _soundIn.Stop();
                _soundIn.Dispose();
                _soundIn = null;
                _finalSource.Dispose();

                if (_writer is IDisposable)
                    ((IDisposable)_writer).Dispose();

                btnStop.Enabled = false;
                btnStart.Enabled = true;
            }
        }

        private void deviceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (deviceList.SelectedItems.Count > 0)
            {
                SelectedDevice = (MMDevice)deviceList.SelectedItems[0].Tag;
            }
            else
            {
                SelectedDevice = null;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            StopCapture();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Start_Form Start_Form = new Start_Form();
            Start_Form.ShowDialog();
            Close();
        }
    }

    public enum CaptureMode
    {
        Capture,
        LoopbackCapture
    }
}
