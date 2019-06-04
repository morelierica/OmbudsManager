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
    public partial class Setor : Form
    {
        public Setor()
        {
            InitializeComponent();
        }

        private void buttonNova_Click(object sender, EventArgs e)
        {
            View.CadastroSetores cadastroSetores = new View.CadastroSetores();
            cadastroSetores.Show();
            this.Close();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            View.ConsultaSetor consultaSetor = new View.ConsultaSetor();
            consultaSetor.Show();
            this.Close();
        }
    }
}
