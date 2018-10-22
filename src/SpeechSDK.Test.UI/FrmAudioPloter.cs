using Accord.Audio;
using Accord.Audio.Filters;
using Accord.Controls;
using SpeechSDK.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechSDK.Test.UI
{
    public partial class FrmAudioPloter : Form
    {
        public FrmAudioPloter()
        {
            InitializeComponent();
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            Testar();


            using (var processador = new PreparadorAudio(txtArquivo.Text))
            using (var signal = processador.ObterSinal())
            {
                var monoFilter = new MonoFilter();

                using (var monoSignal = monoFilter.Apply(signal))
                {
                    var floatSignalArray = monoSignal.ToFloat();

                    var floatSignalFiltradoArray = floatSignalArray.Where(s => s < -0.01 || s > 0.01).ToArray();

                    var filter = new HighPassFilter(0.02f);

                    using (var filterSignal = filter.Apply(monoSignal))
                    {
                        WavechartBox.Show(filterSignal.ToFloat(), "sinal filtrado", nonBlocking: true);
                    }

                    WavechartBox.Show(floatSignalArray, "sinal original", nonBlocking: true);

                    WavechartBox.Show(floatSignalFiltradoArray, "sinal sem silencio", nonBlocking: true);

                    var teste = processador.ObterAudioFiltrado().ToArray();

                    var valores = teste.Select(v => (float)v.Descriptor.Average()).ToArray();
                    WavechartBox.Show(valores, "MFCC", nonBlocking: true);
                }
            }
        }

        private void Testar()
        {
            var speechCore = new SpeechCore();

            speechCore.AdicionarModelo(new AudioModel(@".\Audios\Giovanni\audio_01.wav",
                                                      @".\Audios\Giovanni\audio_02.wav",
                                                      @".\Audios\Giovanni\audio_03.wav"));

            speechCore.AdicionarModelo(new AudioModel(@".\Audios\Sidney\audio_01.wav",
                                                      @".\Audios\Sidney\audio_02.wav",
                                                      @".\Audios\Sidney\audio_03.wav"));

            speechCore.AdicionarModelo(new AudioModel(@".\Audios\marcos\audio_01.wav"));


            speechCore.Treinar();
        }
    }
}
