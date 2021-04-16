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
        private readonly Live_Play _live = new Live_Play();
        private readonly Effecter _effects = new Effecter();
        //private WasapiCapture capture = null;
        //private WaveWriter w = null;
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
            try
            {
                _live.play();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        
        private void Stop_btn_Click(object sender, EventArgs e)
        {
            _live.stop();
            /*
            if (w != null && capture != null)
            {
                //stop recording 
                capture.Stop();
                w.Dispose();
                w = null;
                capture.Dispose();
                capture = null;
            }*/
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
                _effects.Rever();
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
                _effects.Distortion();   
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
                _effects.Chorus();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
