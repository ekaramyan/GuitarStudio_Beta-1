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
    public class Effecter : Component
    {
        private ISoundOut _soundOut;
        private readonly Live_Play _live = new Live_Play();
        //private WasapiCapture capture = null;
        // private WaveWriter w = null;
        public Single InGain;
        public Single Gain;
        public Single Edge;
        public Single PreLowpassCutoff;
        public Single Delay;
        public Single Depth;
        public Single PostEQCenterFrequency;
        public Single PostEQBandwidth;
        public void Rever()
        {
            var soundIn = new WasapiCapture(true, AudioClientShareMode.Shared, 30);
            soundIn.Initialize();
            IWaveSource source = new SoundInSource(soundIn) { FillWithZeros = true };
            PreLowpassCutoff = 56;
            InGain = 10;
            var eSource = new DmoWavesReverbEffect(source);
            soundIn.Start();
            _soundOut = new WasapiOut();
            _soundOut.Initialize(eSource);
            _soundOut.Play();
        }
        public void Distortion()
        {
            var soundIn = new WasapiCapture(true, AudioClientShareMode.Shared, 30);
            soundIn.Initialize();
            IWaveSource source = new SoundInSource(soundIn) { FillWithZeros = true };
            Gain = 200;
            Edge = 155;
            PreLowpassCutoff = 56;
            PostEQCenterFrequency = 100;
            PostEQBandwidth = 10;
            var eSource = new DmoDistortionEffect(source);
            soundIn.Start();
            _soundOut = new WasapiOut();
            _soundOut.Initialize(eSource);
            _soundOut.Play();
        }
        public void Chorus()
        {
            var soundIn = new WasapiCapture(true, AudioClientShareMode.Shared, 30);
            soundIn.Initialize();
            IWaveSource source = new SoundInSource(soundIn) { FillWithZeros = true };
            PreLowpassCutoff = 56;
            Delay = 10;
            Depth = 10;
            var eSource = new DmoChorusEffect(source);
            soundIn.Start();
            _soundOut = new WasapiOut();
            _soundOut.Initialize(eSource);
            _soundOut.Play();
        }
        public void Stop()
        {
            if (_soundOut != null)
                _soundOut.Stop();
        }
    }
}
