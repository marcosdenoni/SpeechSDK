using Accord.Audio;
using Accord.Controls;
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
            GerarBitmap();

            using (var processador = new PreparadorAudio(txtArquivo.Text))
            {
                using (var signal = processador.ObterSinal())
                {
                    var chart = new Wavechart();

                    chart.Dock = DockStyle.Fill;

                    groupBox1.Controls.Add(chart);

                    //signal.SampleRate

                    //var complexSignal = ComplexSignal.FromSignal(signal);

                    //chart.AddWaveform("Original", Color.Green, 3);
                    //chart.UpdateWaveform("Original",signal.)

                    //var complexSignal = ComplexSignal.FromSignal(signal);
                    //// Transform to the complex domain
                    //complexSignal.ForwardFourierTransform();

                    //// Now we can get the power spectrum output and its
                    //// related frequency vector to plot our spectrometer.

                    ////Accord.Math.Transforms.FourierTransform2

                    //Complex[] channel = complexSignal.GetChannel(0);


                    //processador.ObterAudioFiltrado();

                    //float[] testValues = signal.ToFloat().Take(128).ToArray();

                    //// fill data series
                    //for (int i = 0; i < 128; i++)
                    //{
                    //    testValues[i] = (float)Math.Sin(i / 18.0 * Math.PI);

                    //}
                    //// add new waveform to the chart
                    //chart.AddWaveform("Test", Color.DarkGreen, 3);
                    //// update the chart
                    //chart.UpdateWaveform("Test", testValues);

                    WavechartBox.Show(signal.ToFloat(), "teste");
                    var teste = processador.ObterAudioFiltrado();

                    var valores = teste.Select(v => (float)v.Item2.Average()).ToArray();
                    WavechartBox.Show(valores, "teste2");



                    //chart.AddWaveform("fft", Color.Green, 5);
                    //chart.UpdateWaveform("fft", signal.ToFloat().Take(200).ToArray());
                }
            }
        }


        private void GerarBitmap()
        {
            using (var processador = new PreparadorAudio(txtArquivo.Text))
            using (var signal = processador.ObterSinal())
            {

                //var signalArray = signal.ToDouble();





             
            }
        }
    }
}
