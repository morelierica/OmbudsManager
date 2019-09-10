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
using CpfLibrary;


namespace TG.View
{
    public partial class CadastroUsuarios : Form
    {
        public CadastroUsuarios()
        {
            InitializeComponent();
        }

        private void CadastroUsuarios_Load(object sender, EventArgs e)
        {
            maskedTextBoxCpf.Mask = "000,000,000-00";
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxCodigo.Clear();
            textBoxNome.Clear();
            maskedTextBoxCpf.Clear();
            textBoxLogin.Clear();
            textBoxLogin2.Clear();
            textBoxSenha.Clear();
            textBoxSenha2.Clear();
            dateTimePickerDataNasc.ResetText();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string dataValidacao = DateTime.Now.AddYears(-16).ToShortDateString();
            DateTime dataValida = Convert.ToDateTime(DateTime.Now.AddYears(-16).ToShortDateString());

            //Validações de preenchimento do cadastro
            if (Convert.ToDateTime(dateTimePickerDataNasc.Text) >= Convert.ToDateTime(dataValidacao))
            {
                MessageBox.Show("Idade do usuário deve ser superior a 16 anos.", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxNome.TextLength <= 0 || maskedTextBoxCpf.TextLength <= 0 || textBoxLogin.TextLength <= 0 || textBoxSenha.TextLength <= 0)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxLogin.TextLength > 0 && textBoxLogin2.TextLength <= 0)
            {
                MessageBox.Show("O login deve ser confirmado!", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxSenha.TextLength > 0 && textBoxSenha2.TextLength <= 0)
            {
                MessageBox.Show("A senha deve ser confirmada!", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxLogin.Text != textBoxLogin2.Text)
            {
                MessageBox.Show("Os logins não correspondem!", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxSenha.Text != textBoxSenha2.Text)
            {
                MessageBox.Show("As senhas não correspondem!", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Aqui será utilizado o metodo CadastrarUsuario da classe User para inserir os dados no BD
            else
            {
                //Inserindo os valores aos atributos da classe User
                User usuario = new User();
                usuario.nome_usuario = textBoxNome.Text;
                usuario.data_nasc_usuario = dateTimePickerDataNasc.Value;
                usuario.cpf_usuario = maskedTextBoxCpf.Text;
                usuario.login_usuario = textBoxLogin2.Text;
                usuario.senha_usuario = textBoxSenha2.Text;

                //Chamando o metodo que cadastra o usuario
                usuario.CadastrarUsuario();

                MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        
        //Validação de CPF do usuário
        private void maskedTextBoxCpf_Leave(object sender, EventArgs e)
        {
            Boolean resposta = Cpf.Check(maskedTextBoxCpf.Text);

            if (resposta == false)
            {
                MessageBox.Show("Digite um CPF válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTextBoxCpf.Clear();
                maskedTextBoxCpf.Select();
            }
        }
    }
}
