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
    public class PreparadorAudio:IDisposable
    {
        public string ArquivoAudio { get; private set; }

        private IAudioDecoder _audioDecoder;

        public PreparadorAudio(string arquivoAudio)
        {
            ArquivoAudio = arquivoAudio;
            _audioDecoder = new WaveDecoder(arquivoAudio);
        }

        public Signal ObterSinal()
        {
            return _audioDecoder.Decode();
        }

        public IEnumerable<Tuple<int,double[]>> ObterAudioFiltrado()
        {
            using (var signal = ObterSinal())
            using (var mfcc = new MelFrequencyCepstrumCoefficient())
            {
                var mfccTransformResult = mfcc.Transform(signal);

                //signal.RawData

                foreach (var mfccTransformItem in mfccTransformResult)
                {
                    yield return new Tuple<int, double[]>(mfccTransformItem.Frame, mfccTransformItem.Descriptor);
                }
            }
        }

        
        public void Dispose()
        {
            
        }

    }
}
