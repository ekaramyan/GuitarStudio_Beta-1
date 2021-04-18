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

    class Chorus
    {
    private ISoundOut _soundOut;
    public Single PreLowpassCutoff;
    public Single Delay;
    public Single Depth;
        public void Chor()
        {
            var soundIn = new WasapiCapture(true, AudioClientShareMode.Shared, 10);
            soundIn.Initialize();
            IWaveSource source = new SoundInSource(soundIn) { FillWithZeros = true };
            PreLowpassCutoff = 110;
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
