using Accord.Audio;
using Accord.Audio.Formats;
using SpeechSDK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechSDK
{
    static class AudioModelHelper
    {       
        public static double[] ObterSaidaEsperada(this AudioModel audioModel)
        {
            return new double[] { Convert.ToDouble(audioModel.GetHashCode()) };
        }

        public static IEnumerable<double[]> ObterCaracteristicas(this AudioModel audioModel, int quebraSaida = 1400)
        {
            return audioModel.Audios.SelectMany(a => ObterCaracteristicas(a, quebraSaida));
        }


        public static IEnumerable<double[]> ObterCaracteristicas(string arquivoAudio, int quebraSaida = 1400)
        {
            var audioDecoder = new WaveDecoder(arquivoAudio);
            using (var signal = audioDecoder.Decode())
            {
                var mFCCDescriptor = ObterMFCCDescriptor(signal);

                int counter = 0;

                var buffer = new double[quebraSaida];

                foreach (var mFCCDescriptorItem in mFCCDescriptor)
                {
                    foreach (var item in mFCCDescriptorItem.Descriptor)
                    {
                        buffer[counter] = item;

                        counter++;
                        if (counter == quebraSaida)
                        {
                            yield return buffer;

                            buffer = new double[quebraSaida];
                            counter = 0;
                        }
                    }
                }
            }
        }

        public static IEnumerable<MelFrequencyCepstrumCoefficientDescriptor> ObterMFCCDescriptor(Signal signal)
        {
            using (var mfcc = new MelFrequencyCepstrumCoefficient())
            {
                var mfccTransformResult = mfcc.Transform(signal);

                foreach (var mfccTransformItem in mfccTransformResult)
                {
                    yield return mfccTransformItem;
                }
            }
        }
    }
}
