using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TG_V1_Telas.Model;
using Npgsql;

namespace TG_V1_Telas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string codigoUsuario = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxLogin.Select();
            this.AcceptButton = buttonEntrar;

            //Preencher comboBox Login
            //Abrindo a conexão com o banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            try
            {
                NpgsqlCommand comando = new NpgsqlCommand();
                comando.Connection = conn;
                comando.CommandText = "SELECT cod_usuario, login_usuario FROM usuario ORDER BY login_usuario ASC";
                NpgsqlDataReader reader = comando.ExecuteReader(); //retorna dados resultantes da consulta SQL
                DataTable table = new DataTable(); //estrutura da tabela do banco de dados
                table.Load(reader); //carrega dados na tabela de acordo com a instrução SQL passada
                DataRow row = table.NewRow(); //representa uma linha de dados em um DataTable
                row["login_usuario"] = ""; //para não gerar valor nulo e evitar erro de execução
                table.Rows.InsertAt(row, 0); //Insere nova linha na coleção no local especificado

                this.comboBoxLogin.DataSource = table; //atribui o objeto DataTable a instancia SQL a ser conectada
                this.comboBoxLogin.ValueMember = "cod_usuario"; //Obtenção do valor do membro (código do convenio)
                this.comboBoxLogin.DisplayMember = "login_usuario"; //Obtenção do nome do membro

                reader.Close();
                reader.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível preencher o comboBox\n\nErro: " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            //query para verificar se usuario e senha existem no BD
            String query = "SELECT * FROM usuario WHERE login_usuario=@login_usuario AND senha_usuario=@senha_usuario";

            //Abrindo a conexão com o banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            //Executando a query
            NpgsqlCommand comando = new NpgsqlCommand(query, conn);

            //Pegando usuario e senha das texBox
            comando.Parameters.AddWithValue("@login_usuario", comboBoxLogin.Text);
            comando.Parameters.AddWithValue("@senha_usuario", textBoxSenha.Text);

            //Leitor do banco de dados
            NpgsqlDataReader leitor = comando.ExecuteReader();
           
            //Verificando se usuario e senha digitados estão corretos
            if (leitor.Read())
            {
                Autenticacao.login(leitor["login_usuario"].ToString(), leitor["senha_usuario"].ToString());
                codigoUsuario = leitor["nome_usuario"].ToString();
                Home home = new Home(codigoUsuario);
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha incorretos!", "Erro ao efetuar Login",MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxLogin.SelectedValue = -1;
                textBoxSenha.Clear();
                comboBoxLogin.Select();
            }
        }
    }
}
