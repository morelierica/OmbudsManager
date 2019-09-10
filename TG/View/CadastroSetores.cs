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
    public partial class CadastroSetores : Form
    {
        public CadastroSetores()
        {
            InitializeComponent();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNome.Clear();
            textBoxEmailCoord.Clear();
            textBoxCoordenador.Clear();
        }

        private void CadastroSetores_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            //Validacao de preenchimento
            if (textBoxNomeSetor.TextLength <= 0 || textBoxCoordenador.TextLength <= 0 || textBoxEmailCoord.TextLength <= 0)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Aqui será utilizado o metodo CadastrarSetor da classe Sector para inserir os dados no BD
            else
            {
                //Inserindo os valores aos atributos da classe Sector
                Sector setor = new Sector();
                setor.nome_setor = textBoxNomeSetor.Text;
                setor.coord_setor = textBoxCoordenador.Text;
                setor.email_coord = textBoxEmailCoord.Text;

                //Chamando o metodo que cadastra o Setor
                setor.CadastrarSetor();

                MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
