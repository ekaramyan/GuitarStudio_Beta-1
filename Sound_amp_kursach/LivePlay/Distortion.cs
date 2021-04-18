using CSCore;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using CSCore.SoundOut;
using CSCore.Streams;
using CSCore.Streams.Effects;
using System;
using System.ComponentModel;

namespace DigitalGuitarAmp
{
    public class Distortion : Component
    {
        private ISoundOut _soundOut;
        //private ILive _ILive;
        public Single InGain;
        public Single Gain;
        public Single Edge;
        public Single PreLowpassCutoff;
        public Single Delay;
        public Single Depth;
        public Single PostEQCenterFrequency;
        public Single PostEQBandwidth;
        public void Dist()
        {
            var soundIn = new WasapiCapture(true, AudioClientShareMode.Shared, 10);
            soundIn.Initialize();
            IWaveSource source = new SoundInSource(soundIn) { FillWithZeros = true };
            Gain = 200;
            Edge = 155;
            PreLowpassCutoff = 110;
            PostEQCenterFrequency = 100;
            PostEQBandwidth = 10;
            var eSource = new DmoDistortionEffect(source);
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
