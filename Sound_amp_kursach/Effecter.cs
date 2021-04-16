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
            var soundOut = new WasapiOut();
            soundOut.Initialize(eSource);
            soundOut.Play();
        }
        public void Distortion()
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
            var soundOut = new WasapiOut();
            soundOut.Initialize(eSource);
            soundOut.Play();
        }
    }
}
