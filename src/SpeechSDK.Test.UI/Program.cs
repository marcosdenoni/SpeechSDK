using SpeechSDK.Test.UI.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechSDK.Test.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                SpeechConfig.Load();
            }
            catch (Exception ex)
            {
                if (MessageBox.Show("Não foi possivel carregar o config, deseja criar?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    SpeechConfig.CreateConfiguration();
                else
                    return;
            }
            //new PreparadorAudio().Teste();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmAudioPloter());
            Application.Run(new FrmTest());

            SpeechConfig.Save();
        }
    }
}
