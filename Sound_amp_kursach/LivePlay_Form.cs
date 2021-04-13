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
using CSCore.Codecs.WAV;

namespace Sound_amp_kursach
{
    public partial class LivePlay_Form : Form
    {
        private WasapiCapture capture = null;
        private WaveWriter w = null;
        public Single InGain;
        public Single Gain;
        public Single Edge;
        public Single PreLowpassCutoff;
        public Single Delay;
        public Single Depth;
        public Single PostEQCenterFrequency;
        public Single PostEQBandwidth;
        public LivePlay_Form()
        {
            InitializeComponent();
            var soundOut = new WasapiOut();
        }

        private void LivePlay_Form_Load(object sender, EventArgs e)
        {

        }
        private void Play_btn_Click(object sender, EventArgs e)
        {
            Play();
        }
        void Play()
        {
            //using (var soundIn = new WasapiCapture(true, AudioClientShareMode.Shared, 30))
            {
                try
                {
                    //var soundIn = new WasapiLoopbackCapture();
                    var soundIn = new WasapiCapture(true, AudioClientShareMode.Shared, 30);
                    soundIn.Initialize();
                    IWaveSource source = new SoundInSource(soundIn) { FillWithZeros = true };
                    var eSource = new DmoCompressorEffect(source);
                    soundIn.Start();
                    var soundOut = new WasapiOut();
                    soundOut.Initialize(eSource);
                    soundOut.Play();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }

        private void Stop_btn_Click(object sender, EventArgs e)
        {
            if (w != null && capture != null)
            {
                //stop recording 
                capture.Stop();
                w.Dispose();
                w = null;
                capture.Dispose();
                capture = null;
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Start_Form Start_Form = new Start_Form();
            Start_Form.ShowDialog();
            Close();
        }

        private void Reverb_btn_Click(object sender, EventArgs e)
        {
                try
                {
                    var soundIn = new WasapiCapture(true, AudioClientShareMode.Shared, 30);
                    soundIn.Initialize();
                    IWaveSource source = new SoundInSource(soundIn) { FillWithZeros = true };
                    InGain = 10;
                    var eSource = new DmoWavesReverbEffect(source);
                    soundIn.Start();
                    var soundOut = new WasapiOut();
                    soundOut.Initialize(eSource);
                    soundOut.Play();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
        }

        private void Distortion_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var soundIn = new WasapiCapture(true, AudioClientShareMode.Shared, 30);
                soundIn.Initialize();
                IWaveSource source = new SoundInSource(soundIn) { FillWithZeros = true };
                Gain = 200;
                Edge = 155;
                PreLowpassCutoff = 56;
                var eSource = new DmoDistortionEffect(source);
                soundIn.Start();
                var soundOut = new WasapiOut();
                soundOut.Initialize(eSource);
                soundOut.Play();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Chorus_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var soundIn = new WasapiCapture(true, AudioClientShareMode.Shared, 30);
                soundIn.Initialize();
                IWaveSource source = new SoundInSource(soundIn) { FillWithZeros = true };
                Delay = 10;
                Depth = 10;
                var eSource = new DmoChorusEffect(source);
                soundIn.Start();
                var soundOut = new WasapiOut();
                soundOut.Initialize(eSource);
                soundOut.Play();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
