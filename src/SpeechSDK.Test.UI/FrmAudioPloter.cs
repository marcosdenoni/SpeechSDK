using Accord.Audio;
using Accord.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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


                    processador.ObterAudioFiltrado();


                    chart.AddWaveform("fft", Color.Green, 5);
                    chart.UpdateWaveform("fft", signal.ToFloat().Take(200).ToArray());
                }
            }
        }
    }
}
