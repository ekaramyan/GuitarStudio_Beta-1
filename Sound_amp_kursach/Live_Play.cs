using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using CSCore.SoundOut;
using CSCore.Streams;
using CSCore.Streams.Effects;
using CSCore.Codecs.WAV;

namespace Sound_amp_kursach
{
   public class Live_Play : Component
    {
        private WasapiCapture capture = null;
        private WaveWriter w = null;
        //public var SoundIn = new WasapiCapture(true, AudioClientShareMode.Shared, 30);
        public void play()
        {
            var soundIn = new WasapiCapture(true, AudioClientShareMode.Shared, 30);
            soundIn.Initialize();
            IWaveSource source = new SoundInSource(soundIn) { FillWithZeros = true };
            var eSource = new DmoCompressorEffect(source);
            soundIn.Start();
            var soundOut = new WasapiOut();
            soundOut.Initialize(eSource);
            soundOut.Play();
        }
        public void stop()
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

    }
}
