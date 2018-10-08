using Accord.Audio;
using Accord.Audio.Formats;
using Accord.DirectSound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechSDK
{
    public class Class1
    {
        public void Teste()
        {
            var decoder = new WaveDecoder(@"C:\a\audio01.wav");
            
            var teste = new WaveFileAudioSource(@"C:\a\audio01.wav");

            

            using (var signal = AudioDecoder.DecodeFromFile(@"C:\a\audio01.m4a"))
            //using (var signal = decoder.Decode())
            using (var mfcc = new MelFrequencyCepstrumCoefficient())
            {
                var mfccTransformResult = mfcc.Transform(signal);

                foreach (var mfccTransformItem in mfccTransformResult)
                {
                    var bytes = mfccTransformItem.ToByteArray();
                }
            }
        }
    }
}
