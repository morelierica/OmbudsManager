using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TG.Model;

namespace TG.View
{
    public partial class CadastroConvenios : Form
    {
        public CadastroConvenios()
        {
            InitializeComponent();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNomeConvenio.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (textBoxNomeConvenio.TextLength <= 0)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Aqui será utilizado o método CadastrarConvenio da classe Convenant para inserir os dados no BD
            else
            {
                //Inserindo os valores aos atributos da classe Convenant
                Convenant convenio = new Convenant();
                convenio.nome_convenio = textBoxNomeConvenio.Text;

                
                //Chamando o método CadastrarSetor
                convenio.CadastrarConvenio();

                MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
