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
using TG_V1_Telas.Model;

namespace TG_V1_Telas.View
{
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }

        //Puxando o código do usuário do outro Form 
        public EditarUsuario(int codigo_usuario)
        {
            InitializeComponent();
            textBoxCodigo.Text = codigo_usuario.ToString();
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            //Verificar qual usuário selecionado para editar e preencher as textBox com as informações dele 
            
            //query para pegar os dados do usuario no banco de dados
            String query = "SELECT * FROM usuario WHERE cod_usuario=@cod_usuario";

            //Abrindo a conexão com o banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            //Executando a query
            NpgsqlCommand comando = new NpgsqlCommand(query, conn);

            //Transformando o código de string para inteiro
            int codigoInteiro = Convert.ToInt32(textBoxCodigo.Text);

            //Atribuindo o código na variável da query
            comando.Parameters.AddWithValue("@cod_usuario", codigoInteiro);

            //Leitor do banco de dados
            NpgsqlDataReader leitor = comando.ExecuteReader();

            if (leitor.Read())
            {
                //Preenchendo as textbox com os dados do usuário pesquisado
                string nome = leitor["nome_usuario"].ToString();
                textBoxNome.Text = nome;

                string data = leitor["data_nasc_usuario"].ToString();
                dateTimePickerDataNasc.Text = data;

                string cpf = leitor["cpf_usuario"].ToString();
                maskedTextBoxCpf.Text = cpf;
            }
            else
            {
                MessageBox.Show("Erro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja salvar as alterações?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (result == DialogResult.OK)
            {
                User user = new User();
                int codInteiro = Convert.ToInt32(textBoxCodigo.Text);
                user.cod_usuario = codInteiro;
                user.nome_usuario = textBoxNome.Text;
                user.data_nasc_usuario = dateTimePickerDataNasc.Value;
                user.cpf_usuario = maskedTextBoxCpf.Text;

                user.EditarUsuario();

                MessageBox.Show("Dados alterados com sucesso!", "Alteração Efetuada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Operação Cancelada pelo usuário", "Operação Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
