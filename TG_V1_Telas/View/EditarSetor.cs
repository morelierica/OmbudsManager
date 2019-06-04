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
    public partial class EditarSetor : Form
    {
        public EditarSetor()
        {
            InitializeComponent();
        }

        public EditarSetor(int codigo_setor)
        {
            InitializeComponent();
            textBoxCodSetor.Text = codigo_setor.ToString();
        }

        private void EditarSetor_Load(object sender, EventArgs e)
        {
            //Verificar qual o setor selecionado para editar e preencher as textBox com as informações dele 

            //query para pegar os dados do setor no banco de dados
            String query = "SELECT * FROM setor WHERE cod_setor=@cod_setor";

            //Abrindo a conexão com o banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            //Executando a query
            NpgsqlCommand comando = new NpgsqlCommand(query, conn);

            //Transformando o código do setor de string para inteiro
            int codigoInteiro = Convert.ToInt32(textBoxCodSetor.Text);

            //Atribuindo o código na variável da query
            comando.Parameters.AddWithValue("@cod_setor", codigoInteiro);

            //Leitor do banco de dados
            NpgsqlDataReader leitor = comando.ExecuteReader();

            if (leitor.Read())
            {
                //Preenchendo as textbox com os dados do setor pesquisado
                string nome = leitor["nome_setor"].ToString();
                textBoxNomeSetor.Text = nome;

                string coordenador = leitor["coord_setor"].ToString();
                textBoxCoordenador.Text = coordenador;

                string email = leitor["email_coord"].ToString();
                textBoxEmailCoord.Text = email;
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
                Sector sector = new Sector();
                
                int codInteiro = Convert.ToInt32(textBoxCodSetor.Text);
                sector.cod_setor = codInteiro;
                sector.nome_setor = textBoxNomeSetor.Text;
                sector.coord_setor = textBoxCoordenador.Text;
                sector.email_coord = textBoxEmailCoord.Text;

                sector.EditarSetor();

                MessageBox.Show("Dados alterados com sucesso!", "Alteração Efetuada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Operação Cancelada pelo usuário", "Operação Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
