using Accord.Audio;
using Accord.Audio.Filters;
using Accord.Controls;
using SpeechSDK.Model;
using SpeechSDK.Test.UI.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechSDK.Test.UI
{
    public partial class FrmAnalise : Form
    {
        public FrmAnalise()
        {
            InitializeComponent();
        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtArquivoAudio.Text) || !File.Exists(txtArquivoAudio.Text))
                return;

            try
            {
                using (var sinal = AudioModelHelper.ObterSinal(txtArquivoAudio.Text))
                    RenderizarSinal(sinal, false);


                using (var sinal = AudioModelHelper.ObterSinalLimpo(txtArquivoAudio.Text))
                    RenderizarSinal(sinal, true);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao analisar audio.");
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

        private void btnSelecionarAudio_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtArquivoAudio.Text = openFileDialog1.FileName;
            }
        }

        private void btnClassificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtArquivoAudio.Text) || !File.Exists(txtArquivoAudio.Text))
                return;


            txtResultado.Text = string.Empty;

            var cronometro = new Stopwatch();
            cronometro.Start();

            var core = new SpeechCore();

            foreach (var modelo in SpeechConfig.Instance.Modelos)
            {
                var audioModel = new AudioModel(modelo.Arquivos.ToArray());
                audioModel.Descricao = modelo.Nome;
                core.AdicionarModelo(audioModel);
            }

            core.Treinar();

            cronometro.Stop();

            WriteLine($"Tempo de treinamento: {cronometro.Elapsed}");

            cronometro.Reset();
            cronometro.Start();
            core.Classificar(txtArquivoAudio.Text, WriteLine, Write);

            cronometro.Stop();

            WriteLine($"Tempo de classificação: {cronometro.Elapsed}");


        }

        private void WriteLine(string msg)
        {
            txtResultado.Text += msg + Environment.NewLine;
            Application.DoEvents();
        }

        private void Write(string msg)
        {
            txtResultado.Text += msg;
            Application.DoEvents();
        }
    }
}
