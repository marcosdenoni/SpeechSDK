using System;
using System.Windows.Forms;

namespace SpeechSDK.Test.UI
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
        }

        private void btnEditarModelos_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmModelos())
                frm.ShowDialog();
        }

        private void btnAnalisarAudio_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmAnalise())
                frm.ShowDialog();
        }
    }
}
