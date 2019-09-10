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
using TG.Model;

namespace TG.View
{
    public partial class EditarSenha : Form
    {
        public static string nome_usuario;
        public static string senha_usuario;
        public static int cod_usuario;
        public EditarSenha()
        {
            InitializeComponent();
        }

        public EditarSenha(string usuario)
        {
            InitializeComponent();
            nome_usuario = usuario;
        }

        private void EditarSenha_Load(object sender, EventArgs e)
        {
            //query para pegar os dados do usuario no banco de dados
            String query = "SELECT * FROM usuario WHERE nome_usuario=@nome_usuario";

            //Abrindo a conexão com o banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            //Executando a query
            NpgsqlCommand comando = new NpgsqlCommand(query, conn);
            
            //Atribuindo o código na variável da query
            comando.Parameters.AddWithValue("@nome_usuario", nome_usuario);

            //Leitor do banco de dados
            NpgsqlDataReader leitor = comando.ExecuteReader();

            if (leitor.Read())
            {
                //Preenchendo as textbox com os dados do usuário pesquisado
                string login = leitor["login_usuario"].ToString();
                textBoxUsuario.Text = login;

                string senha = leitor["senha_usuario"].ToString();
                senha_usuario = senha;

                string codigo = leitor["cod_usuario"].ToString();
                cod_usuario = Convert.ToInt32(codigo);
            }
            else
            {
                MessageBox.Show("Erro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string senhaAtual = textBoxSenhaAtual.Text;
            string novaSenha = textBoxNovaSenha.Text;
            string confirmacao = textBoxConfirmacao.Text;

            if(senhaAtual != senha_usuario)
            {
                MessageBox.Show("Senha Atual Incorreta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxSenhaAtual.Clear();
                textBoxNovaSenha.Clear();
                textBoxConfirmacao.Clear();
                textBoxSenhaAtual.Select();
            }
            else if(novaSenha != confirmacao)
            {
                MessageBox.Show("A senha não foi confirmada corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxSenhaAtual.Clear();
                textBoxNovaSenha.Clear();
                textBoxConfirmacao.Clear();
                textBoxSenhaAtual.Select();
            }
            else if (novaSenha.Length == 0 || confirmacao.Length == 0)
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxSenhaAtual.Clear();
                textBoxNovaSenha.Clear();
                textBoxConfirmacao.Clear();
                textBoxSenhaAtual.Select();
            }
            else
            {
                User user = new User();
                user.cod_usuario = cod_usuario;
                user.senha_usuario = novaSenha;

                user.EditarSenha();
                MessageBox.Show("Senha alterada com sucesso!", "Alteração Efetuada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
