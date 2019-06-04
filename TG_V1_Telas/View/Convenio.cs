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
    public partial class Convenio : Form
    {
        public Convenio()
        {
            InitializeComponent();
        }

        private void buttonNova_Click(object sender, EventArgs e)
        {
            View.CadastroConvenios cadastroConvenios = new View.CadastroConvenios();
            cadastroConvenios.Show();
            this.Close();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            ConsultaConvenio consultaConvenio = new ConsultaConvenio();
            consultaConvenio.Show();
            this.Close();
        }
    }
}
