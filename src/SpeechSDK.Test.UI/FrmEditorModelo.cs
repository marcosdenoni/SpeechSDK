using SpeechSDK.Test.UI.Config;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SpeechSDK.Test.UI
{
    public partial class FrmEditorModelo : Form
    {
        public class CaminhoAudio
        {
            public string Caminho { get; set; }
        }

        private BindingList<CaminhoAudio> bind;

        private ClasseModelo modelo;

        public FrmEditorModelo(ClasseModelo modelo = null)
        {
            InitializeComponent();

            this.modelo = modelo;

            bind = new BindingList<CaminhoAudio>();
            grdAudios.DataSource = bind;

            if (modelo != null)
            {
                foreach (var item in modelo.Arquivos)
                    bind.Add(new CaminhoAudio() { Caminho = item });
            }

            if (this.modelo == null)
                this.modelo = new ClasseModelo();

            txtNome.Text = this.modelo.Nome;
            DialogResult = DialogResult.Abort;
        }

        public static ClasseModelo ObterNovoModelo()
        {
            using (FrmEditorModelo form = new FrmEditorModelo())
            {
                if (form.ShowDialog() == DialogResult.OK)
                    return form.modelo;
                return null;
            }
        }

        public static void EditarModelo(ClasseModelo modelo)
        {
            using (FrmEditorModelo form = new FrmEditorModelo(modelo))
            {
                form.ShowDialog();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(modelo.Nome))
            {
                MessageBox.Show("O nome não pode ser vazio.");
                return;
            }

            if(modelo.Quantidade <1)
            {
                MessageBox.Show("Ao menos um audio é necessário.");
                return;
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                foreach (var item in openFileDialog1.FileNames)
                {
                    if (bind.Any(m => m.Caminho == item))
                        continue;

                    bind.Add(new CaminhoAudio() { Caminho = item });
                }

                modelo.Arquivos.Clear();
                modelo.Arquivos.AddRange(bind.Select(m => m.Caminho));
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            modelo.Nome = txtNome.Text;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(grdAudios.SelectedRows.Count > 0 && MessageBox.Show("Deseja remover o audio?", "Aviso",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var caminho = (CaminhoAudio)grdAudios.SelectedRows[0].DataBoundItem;
                bind.Remove(caminho);

                modelo.Arquivos.Clear();
                modelo.Arquivos.AddRange(bind.Select(m => m.Caminho));
            }
        }
    }
}
