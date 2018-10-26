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
        public static IEnumerable<double[]> ObterCaracteristicas(this AudioModel audioModel, int segundosSegmentos) => audioModel.Audios.SelectMany(a => ObterCaracteristicas(a, segundosSegmentos));


        public static Signal ObterSinal(string arquivoAudio)
        {
            var audioDecoder = new WaveDecoder(arquivoAudio);
            return audioDecoder.Decode();
        }

        public static Signal ObterSinalMono(string arquivoAudio)
        {
            var audioDecoder = new WaveDecoder(arquivoAudio);

            using (var originalSignal = audioDecoder.Decode())
            {
                var monoFilter = new MonoFilter();
                return monoFilter.Apply(originalSignal);
            }
        }

        public static Signal ObterSinalLimpo(string arquivoAudio)
        {
            using (var signalMono = ObterSinalMono(arquivoAudio))
            {
                var floatSignal = signalMono.ToFloat();

                var buffer = floatSignal.Where(s => s < -0.008 || s > 0.008).ToArray();

                var outSignal = Signal.FromArray(buffer, 1, signalMono.SampleRate, signalMono.SampleFormat);

                //SalvarSinal(outSignal);

                return outSignal;
            }
        }

        public static void SalvarSinal(Signal signal)
        {
            File.Delete(@"C:\a\teste.wav");
            using (var fs = new FileStream(@"C:\a\teste.wav", FileMode.CreateNew))
            {
                var audioEncoder = new WaveEncoder(fs);
                audioEncoder.Encode(signal);
            }
        }

        public static IEnumerable<Signal> SegmentarSinal(Signal signal, int seconds = 2)
        {
            var floatSignal = signal.ToFloat();

            var buffer = new float[signal.SampleRate * seconds];

            for (int i = 0; i < floatSignal.Length; i += buffer.Length)
            {
                int len = floatSignal.Length - i;

                if (len > buffer.Length)
                {
                    len = buffer.Length;
                    buffer = new float[buffer.Length];
                }

                Array.Copy(floatSignal, i, buffer, 0, len);

                var outSignal = Signal.FromArray(buffer, 1, signal.SampleRate, signal.SampleFormat);

                yield return outSignal;
            }
        }

        public static Signal AplicarFiltroPassaAlta(Signal sinal)
        {
            var highPassFilter = new HighPassFilter(0.9f);

            return highPassFilter.Apply(sinal);
        }

        public static IEnumerable<double[]> AplicarMFCC(Signal signal, int quebraSaida)
        {
            var mFCCDescriptor = ObterMFCCDescriptor(signal);

            int counter = 0;

            var buffer = new double[quebraSaida];

            foreach (var mFCCDescriptorItem in mFCCDescriptor)
            {

                //buffer[counter] = mFCCDescriptorItem.Descriptor.Average();

                //counter++;
                //if (counter == quebraSaida)
                //{
                //    yield return buffer;

                //    buffer = new double[quebraSaida];
                //    counter = 0;
                //}

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

        public static double[] AplicarMFCCNovo(Signal signal, int segundosSegmentos)
        {
            var mFCCDescriptor = ObterMFCCDescriptor(signal);

            int counter = 0;

            var buffer = new double[segundosSegmentos*1400];

            foreach (var mFCCDescriptorItem in mFCCDescriptor)
            {
                foreach (var item in mFCCDescriptorItem.Descriptor)
                {
                    buffer[counter++] = item;
                }
            }

            return buffer;
        }

        /// <summary>
        /// Realiza a obtenção de todos os dados a serem submetidos a rede
        /// </summary>
        /// <param name="arquivoAudio"></param>
        /// <param name="segundosSegmentos"></param>
        /// <returns></returns>
        public static IEnumerable<double[]> ObterCaracteristicas(string arquivoAudio, int segundosSegmentos)
        {
            //using (var signalLimpo = ObterSinalLimpo(arquivoAudio))
            //using (var signal = AplicarFiltroPassaAlta(signalLimpo))
            using (var signal = ObterSinalLimpo(arquivoAudio))
            {
                foreach (var segmentoSignal in SegmentarSinal(signal, segundosSegmentos))
                {
                    yield return AplicarMFCCNovo(segmentoSignal, segundosSegmentos);

                    //foreach (var item in AplicarMFCC(segmentoSignal, quebraSaida))
                    //{
                    //    yield return item;
                    //}
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
