using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TG
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        public static string usuarioLogado = "";
        public Home(string codigoUsuario)
        {
            InitializeComponent();
            textBoxUsuarioLogado.Text = codigoUsuario;
            usuarioLogado = codigoUsuario;
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Usuario usuario = new View.Usuario();
            usuario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovaManif novaManif = new NovaManif(usuarioLogado);
            novaManif.Show();
        }

        private void buttonManifestante_Click(object sender, EventArgs e)
        {
            Manifestante manifestante = new Manifestante();
            manifestante.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Sobre sobre = new View.Sobre();
            sobre.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Setor setor = new View.Setor();
            setor.Show();
        }

        private void convêniosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Convenio convenio = new View.Convenio();
            convenio.Show();
        }

        private void manifestaçõesPorPeríodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.RelatorioPeriodo relatorioPeriodo = new View.RelatorioPeriodo();
            relatorioPeriodo.Show();
        }

        private void manifestaçõesPorStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.RelatorioStatus relatorioStatus = new View.RelatorioStatus();
            relatorioStatus.Show();
        }

        private void manifestaçõesPorManifestanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.RelatorioManifestante relatorioManifestante = new View.RelatorioManifestante();
            relatorioManifestante.Show();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manualDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Projetos\TG\OmbudsManager\TG\Resources\ManualOmbudsManager.pdf");
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.EditarSenha editarSenha = new View.EditarSenha(usuarioLogado);
            editarSenha.Show();
        }

        //Configurando teclas de atalho para os botões
        private void Home_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F8:

                    NovaManif novaManif = new NovaManif(usuarioLogado);
                    novaManif.Show();

                    break;

                case Keys.F9:

                    Manifestante manifestante = new Manifestante();
                    manifestante.Show();

                    break;

                case Keys.F1:

                    System.Diagnostics.Process.Start(@"C:\projetoTG\TG_Ouvidoria\TG\Resources\ManualOmbudsManager.pdf");

                    break;
            }
        }

        //Mostrando as opções de atalho quando o mouse esta em cima do botão
        private void buttonManifestacao_MouseEnter(object sender, EventArgs e)
        {
            labelManifestacao.Visible = true;
        }

        private void buttonManifestacao_MouseLeave(object sender, EventArgs e)
        {
            labelManifestacao.Visible = false;
        }

        private void buttonManifestante_MouseEnter(object sender, EventArgs e)
        {
            labelManifestante.Visible = true;
        }

        private void buttonManifestante_MouseLeave(object sender, EventArgs e)
        {
            labelManifestante.Visible = false;
        }

        private void manifestaçõesPorSetorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.RelatorioSetor relatorioSetor = new View.RelatorioSetor();
            relatorioSetor.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void ajudaToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            labelF1.Visible = true;
        }

        private void ajudaToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            labelF1.Visible = false;
        }
    }
}
