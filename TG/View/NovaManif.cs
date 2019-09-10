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
    public partial class NovaManif : Form
    {
        public NovaManif()
        {
            InitializeComponent();
        }

        public static string usuario = "";
        public NovaManif(string usuarioLogado)
        {
            InitializeComponent();
            usuario = usuarioLogado;
        }

        private void buttonNova_Click(object sender, EventArgs e)
        {
            Manifestacao manifestacao = new Manifestacao(usuario);
            manifestacao.Show();
            this.Close();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            Pesquisa pesquisa = new Pesquisa(usuario);
            pesquisa.Show();
            this.Close();
        }

        private void NovaManif_Load(object sender, EventArgs e)
        {

        }
    }
}
