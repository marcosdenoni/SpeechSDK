using SpeechSDK.Test.UI.Config;
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
    public partial class FrmModelos : Form
    {

        private BindingList<ClasseModelo> bind;


        public FrmModelos()
        {
            InitializeComponent();

            bind = new BindingList<ClasseModelo>(SpeechConfig.Instance.Modelos);
            grdModelos.DataSource = bind;
        }


        public void Bind()
        {
            grdModelos.DataSource = SpeechConfig.Instance.Modelos;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (grdModelos.SelectedRows.Count != 1)
                return;

            var row = grdModelos.SelectedRows[0];
            var modelo = (ClasseModelo)row.DataBoundItem;

            if (MessageBox.Show($"Deseja remover o modelo {modelo.Nome}?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            bind.Remove(modelo);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var modelo = FrmEditorModelo.ObterNovoModelo();
            if (modelo != null)
                bind.Add(modelo);

        }
    }
}
