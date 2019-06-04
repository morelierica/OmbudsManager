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
    public partial class Detalhamento : Form
    {
        public Detalhamento()
        {
            InitializeComponent();
        }

        private void textBoxDetalhamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxRelato.Clear();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAvancar_Click(object sender, EventArgs e)
        {
            View.Resolucao resolucao = new Resolucao();
            resolucao.Show();
            this.Close();
        }
    }
}
