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

namespace TG_V1_Telas
{
    public partial class Manifestacao : Form
    {
        public Manifestacao()
        {
            InitializeComponent();
        }

        public static string usuarioLogado = "";
        public Manifestacao(string usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
        }
        
        //Variaveis globais para verificar qual manifestante está selecionado
        public string selecao;
        public int cod_selecionado;        

        private void Manifestacao_Load(object sender, EventArgs e)
        {
            radioButtonNome.Select();
            maskedTextBoxPesquisa.Select();
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            View.CadastroManifestante cadastroManifestante = new View.CadastroManifestante();
            cadastroManifestante.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selecao = dataGridViewManifestante.CurrentRow.Cells[0].Value.ToString();
            cod_selecionado = Convert.ToInt32(selecao);

            //Abrindo a Tela cadastro de manifestação e levando a variável com o código do manifestante selecionado
            View.CadastroManifestacao cadastroManifestacao = new View.CadastroManifestacao(cod_selecionado, usuarioLogado);
            cadastroManifestacao.Show();
            this.Close();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPesquisa.Text == "")
            {
                MessageBox.Show("Preencha o campo de pesquisa", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (radioButtonNome.Checked)
            {
                try
                {                    
                    string pesquisar = maskedTextBoxPesquisa.Text;
                    string lucas = pesquisar + "%";

                    //Populando dataGridView com informações do banco de dados
                    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
                    conn.Open();
                    NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM manifestante WHERE nome_manifestante ILIKE @nome_manifestante ORDER BY nome_manifestante", conn);
                    comando.Parameters.AddWithValue("@nome_manifestante", lucas);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(comando);                   
                    DataSet ds = new DataSet();
                    DataTable manifestante = new DataTable();                    
                    da.Fill(manifestante);
                    dataGridViewManifestante.DataSource = manifestante;                    
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Nome não localizado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }               
            }
            else if (radioButtonCodigo.Checked)
            {
                try
                {
                    string pesquisar = maskedTextBoxPesquisa.Text;
                    int codPesquisar = Convert.ToInt32(pesquisar);

                    //Populando dataGridView com informações do banco de dados
                    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
                    conn.Open();
                    NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM manifestante WHERE cod_manifestante = @cod_manifestante", conn);
                    comando.Parameters.AddWithValue("@cod_manifestante", codPesquisar);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(comando);
                    DataSet ds = new DataSet();
                    DataTable manifestante = new DataTable();
                    da.Fill(manifestante);
                    dataGridViewManifestante.DataSource = manifestante;
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Código não localizado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (radioButtonDocumento.Checked)
            {
                try
                {
                    string pesquisar = maskedTextBoxPesquisa.Text;

                    //Populando dataGridView com informações do banco de dados
                    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
                    conn.Open();
                    NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM manifestante WHERE cpf_manifestante = @cpf_manifestante", conn);
                    comando.Parameters.AddWithValue("@cpf_manifestante", pesquisar);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(comando);
                    DataSet ds = new DataSet();
                    DataTable manifestante = new DataTable();
                    da.Fill(manifestante);
                    dataGridViewManifestante.DataSource = manifestante;
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("CPF não localizado", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
            else if (radioButtonData.Checked)
            {
                try
                {
                    string pesquisar = maskedTextBoxPesquisa.Text;
                    DateTime dataConvertida = Convert.ToDateTime(pesquisar);

                    //Populando dataGridView com informações do banco de dados
                    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
                    conn.Open();
                    NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM manifestante WHERE data_nasc_manifestante = @data_nasc_manifestante", conn);
                    comando.Parameters.AddWithValue("@data_nasc_manifestante", dataConvertida);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(comando);
                    DataSet ds = new DataSet();
                    DataTable manifestante = new DataTable();
                    da.Fill(manifestante);
                    dataGridViewManifestante.DataSource = manifestante;
                    conn.Close();
                }

                catch
                {
                    MessageBox.Show("Data de nascimento não localizada","Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void radioButtonDocumento_Enter(object sender, EventArgs e)
        {
            maskedTextBoxPesquisa.Mask = "000,000,000-00";
            maskedTextBoxPesquisa.Clear();
            maskedTextBoxPesquisa.Select();
        }

        private void radioButtonData_Enter(object sender, EventArgs e)
        {
            maskedTextBoxPesquisa.Mask = "00-00-0000";
            maskedTextBoxPesquisa.Clear();
            maskedTextBoxPesquisa.Select();
        }

        private void radioButtonNome_Enter(object sender, EventArgs e)
        {
            maskedTextBoxPesquisa.Mask = "";
            maskedTextBoxPesquisa.Clear();
            maskedTextBoxPesquisa.Select();
        }

        private void radioButtonCodigo_Enter(object sender, EventArgs e)
        {
            maskedTextBoxPesquisa.Mask = "000000";
            maskedTextBoxPesquisa.Clear();
            maskedTextBoxPesquisa.Select();
        }
    }
}
