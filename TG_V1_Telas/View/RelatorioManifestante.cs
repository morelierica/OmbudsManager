using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TG_V1_Telas.View
{
    public partial class RelatorioManifestante : Form
    {
        public RelatorioManifestante()
        {
            InitializeComponent();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            int codManifestante = Convert.ToInt32(maskedTextBoxPesquisa.Text);
            View.VisualizaRptManifestante visualizaRptManifestante = new VisualizaRptManifestante(codManifestante);
            visualizaRptManifestante.Show();
            this.Close();
        }

        private void RelatorioManifestante_Load(object sender, EventArgs e)
        {
            maskedTextBoxPesquisa.Mask = "000000";
        }
    }
}
