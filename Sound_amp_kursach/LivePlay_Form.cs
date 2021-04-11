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

namespace Sound_amp_kursach
{
    public partial class LivePlay_Form : Form
    {
        
        public LivePlay_Form()
        {
            InitializeComponent();
        }

        private void LivePlay_Form_Load(object sender, EventArgs e)
        {

        }
        private void Play_btn_Click(object sender, EventArgs e)
        {
            Foo();
        }
        static void Foo()
        {
            using (var soundIn = new WasapiCapture(true, AudioClientShareMode.Shared, 30))
            {
                soundIn.Initialize();
                IWaveSource source = new SoundInSource(soundIn) { FillWithZeros = true };
                using (var eSource = new DmoCompressorEffect(source))
                {
                    soundIn.Start();
                    using (var soundOut = new WasapiOut())
                    {
                        soundOut.Initialize(eSource);
                        soundOut.Play();
                    }
                }
            }
        }
        private void Stop_btn_Click(object sender, EventArgs e)
        {
        }
    }
}
