using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using CSCore.SoundOut;
using CSCore.Streams;
using CSCore.Streams.Effects;



namespace Sound_amp_kursach
{
    interface signal_out
    {
        private static void EQ (string[] args)
        {
            using (var capture = new WasapiCapture())
            {
                capture.Initialize();

                using (var source = new SoundInSource(capture))
                {
                    using (var soundOut = new WasapiOut())
                    {
                        capture.Start();



                        soundOut.Initialize(source);
                        soundOut.Play();



                        Console.ReadKey();
                    }
                }
            }
        }
    }
}

