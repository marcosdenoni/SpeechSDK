using Accord.Audio;
using Accord.Audio.Filters;
using Accord.Audio.Formats;
using Accord.Audio.Windows;
using SpeechSDK.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechSDK
{
    public static class AudioModelHelper
    {
        public static double[] ObterSaidaEsperada(this AudioModel audioModel)
        {
            return new double[] { Convert.ToDouble(audioModel.GetHashCode()) };
        }

        public static IEnumerable<double[]> ObterCaracteristicas(this AudioModel audioModel, int quebraSaida = 1400)
        {
            return audioModel.Audios.SelectMany(a => ObterCaracteristicas(a, quebraSaida));
        }


        public static Signal ObterSinal(string arquivoAudio)
        {
            var audioDecoder = new WaveDecoder(arquivoAudio);
            return audioDecoder.Decode();
        }


        public static Signal ObterSinalLimpo(string arquivoAudio)
        {
            var audioDecoder = new WaveDecoder(arquivoAudio);

            using (var stream = new MemoryStream())
            {
                var audioEncoder = new WaveEncoder(stream);

                for (int i = 0; i < audioDecoder.Frames; i++)
                {
                    using (var signal = audioDecoder.Decode(i, 1))
                    {
                        if (signal.ToFloat().Any(s => s < -0.01 || s > 0.01))
                            audioEncoder.Encode(signal);
                    }
                }

                stream.Seek(0, SeekOrigin.Begin);

                var audioLimpoDecoder = new WaveDecoder(stream);
                return audioLimpoDecoder.Decode();
            }
        }

        public static Signal AplicarFiltroPassaAlta(Signal sinal)
        {
            var highPassFilter = new HighPassFilter(0.9f);

            return highPassFilter.Apply(sinal);
        }

        /// <summary>
        /// Realiza a obtenção de todos os dados a serem submetidos a rede
        /// </summary>
        /// <param name="arquivoAudio"></param>
        /// <param name="quebraSaida"></param>
        /// <returns></returns>
        public static IEnumerable<double[]> ObterCaracteristicas(string arquivoAudio, int quebraSaida)
        {
            //using (var signalLimpo = ObterSinalLimpo(arquivoAudio))
            //using (var signal = AplicarFiltroPassaAlta(signalLimpo))

            using (var signal = ObterSinalLimpo(arquivoAudio))
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

        public static IEnumerable<double[]> ObterCaracteristicasVelho(string arquivoAudio, int quebraSaida = 1400)
        {
            using (var signalLimpo = ObterSinalLimpo(arquivoAudio))
            using (var signal = AplicarFiltroPassaAlta(signalLimpo))
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
            using (var mfcc = new MelFrequencyCepstrumCoefficient(filterCount: 20, samplingRate: signal.SampleRate))
            {
                var mfccTransformResult = mfcc.Transform(signal);

                foreach (var mfccTransformItem in mfccTransformResult)
                {
                    yield return mfccTransformItem;
                }
            }
        }

        #region Filtro silencio
        private static bool IsSilence(float amplitude, sbyte threshold)
        {
            double dB = 20 * Math.Log10(Math.Abs(amplitude));
            return dB < threshold;
        }
        #endregion
    }
}
