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
            try
            {
                Testar();

                using (var sinal = AudioModelHelper.ObterSinal(txtArquivo.Text))
                    RenderizarSinal(sinal, false);


                using (var sinal = AudioModelHelper.ObterSinalLimpo(txtArquivo.Text))
                    RenderizarSinal(sinal, true);

            }
            catch (Exception ex)
            {
            }
        }

        private void RenderizarSinal(Signal sinal, bool limpo)
        {
            var floatSinal = sinal.ToFloat();
            WavechartBox.Show(floatSinal, "Sinal " + (limpo ? "Limpo" : "Original"), nonBlocking: true);

            var teste = AudioModelHelper.ObterMFCCDescriptor(sinal);

            var valores = teste.Select(v => (float)v.Descriptor.Average()).ToArray();
            WavechartBox.Show(valores, "MFCC " + (limpo ? "Limpo" : ""), nonBlocking: true);
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
