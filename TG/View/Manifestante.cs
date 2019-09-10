using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TG
{
    public partial class Manifestante : Form
    {
        public Manifestante()
        {
            InitializeComponent();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            View.CadastroManifestante cadastroManifestante = new View.CadastroManifestante();
            cadastroManifestante.Show();
            this.Close();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            View.PesquisaManifestante pesquisaManifestante = new View.PesquisaManifestante();
            pesquisaManifestante.Show();
            this.Close();
        }
    }
}
