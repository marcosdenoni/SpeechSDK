using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            txtArquivoAudio.Text = @"D:\Desktop\Meu\TCC\git\SpeechSDK\src\Audios\audio01.wav";
            label4.Text = "Marcos";
        }
    }
}
