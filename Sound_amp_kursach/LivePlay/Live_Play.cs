﻿using System;
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

namespace DigitalGuitarAmp
{
    
    public class Live_Play : Component
    {
        private ISoundOut _soundOut;
        public void Play()
        {
            var soundIn = new WasapiCapture(true, AudioClientShareMode.Shared, 10);
            soundIn.Initialize();
            IWaveSource source = new SoundInSource(soundIn) { FillWithZeros = true };
            var eSource = new DmoCompressorEffect(source);
            soundIn.Start();
             _soundOut = new WasapiOut();
            _soundOut.Initialize(eSource);
            _soundOut.Play();
        }
        public void Stop()
        {
            if (_soundOut != null)
                _soundOut.Stop();
            /*if (w != null && capture != null)
            {
                //stop recording 
                capture.Stop();
                w.Dispose();
                w = null;
                capture.Dispose();
                capture = null;
            }*/
        }

    }
}
