﻿using System;
using CSCore;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using CSCore.SoundOut;
using CSCore.Streams;
using CSCore.Streams.Effects;

/*проигрывает входящий сигнал, хз почему не работает*/

namespace Sound_amp_kursach
{
    class PlayInputDevice
    {
     /*   static void LivePlay_form()
        {
            Foo();
        }
        static void Foo()
        {
            using (var soundIn = new WasapiCapture(true, AudioClientShareMode.Shared, 30))
            {
                soundIn.Initialize();
                IWaveSource source = new SoundInSource(soundIn) { FillWithZeros = true };
                using (var echoSource = new DmoChorusEffect(source))
                {
                    soundIn.Start();
                    using (var soundOut = new WasapiOut())
                    {
                        soundOut.Initialize(echoSource);
                        soundOut.Play();
                    }
                }
            }
        }*/
    }
}