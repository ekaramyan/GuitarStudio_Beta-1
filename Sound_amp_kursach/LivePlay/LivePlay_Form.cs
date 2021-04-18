using CSCore.SoundOut;
using System;
using System.Windows.Forms;

namespace DigitalGuitarAmp
{
    public partial class LivePlay_Form : Form
    {
        private readonly Live_Play _live = new Live_Play();
        private readonly Distortion _distortion = new Distortion();
        private readonly Chorus _Chorus = new Chorus();
        private readonly Rever _Rever = new Rever();
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
            _distortion.Stop();
            _Rever.Stop();
            _Chorus.Stop();
            try
            {
                _live.Play();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Stop_btn_Click(object sender, EventArgs e)
        {
            _live.Stop();
            _distortion.Stop();
            _Rever.Stop();
            _Chorus.Stop();
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
            _Chorus.Stop();
            _distortion.Stop();
            _live.Stop();
            try
            {
                _Rever.Reverb();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Distortion_btn_Click(object sender, EventArgs e)
        {
            _Chorus.Stop();
            _Rever.Stop();
            _live.Stop();
            try
            {
                _distortion.Dist();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Chorus_btn_Click(object sender, EventArgs e)
        {
            _distortion.Stop();
            _Rever.Stop();
            _live.Stop();
            try
            {
                _Chorus.Chor();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

    }
}
