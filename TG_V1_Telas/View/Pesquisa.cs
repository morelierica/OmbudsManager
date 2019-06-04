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
    public partial class Pesquisa : Form
    {
        public Pesquisa()
        {
            InitializeComponent();
        }
        
        //Variáveis globais que armazenam o código do usuário selecionado
        public string selecao;
        public int cod_selecionado;

        public static string usuario_logado = "";
        public Pesquisa(string usuario)
        {
            InitializeComponent();
            usuario_logado = usuario;
        }

        private void Pesquisa_Load(object sender, EventArgs e)
        {
            radioButtonManifestante.Select();
        }

        private void radioButtonData_Enter(object sender, EventArgs e)
        {
            labelDataInicial.Visible = true;
            labelDataFinal.Visible = true;
            dateTimePickerInicial.Visible = true;
            dateTimePickerFinal.Visible = true;
            maskedTextBoxPesquisa.Visible = false;
            labelPesquisa.Visible = false;
        }

        private void radioButtonManifestante_Enter(object sender, EventArgs e)
        {
            labelDataInicial.Visible = false;
            labelDataFinal.Visible = false;
            dateTimePickerInicial.Visible = false;
            dateTimePickerFinal.Visible = false;
            maskedTextBoxPesquisa.Visible = true;
            labelPesquisa.Visible = true;
            maskedTextBoxPesquisa.Select();
        }

        private void radioButtonProtocolo_Enter(object sender, EventArgs e)
        {
            labelDataInicial.Visible = false;
            labelDataFinal.Visible = false;
            dateTimePickerInicial.Visible = false;
            dateTimePickerFinal.Visible = false;
            maskedTextBoxPesquisa.Visible = true;
            labelPesquisa.Visible = true;
            maskedTextBoxPesquisa.Select();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            if (radioButtonManifestante.Checked)
            {
                try
                {
                    if (maskedTextBoxPesquisa.Text == "")
                    {
                        MessageBox.Show("Preencha o campo de pesquisa", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        maskedTextBoxPesquisa.Select();
                    }
                    else
                    {
                        string pesquisar = maskedTextBoxPesquisa.Text;
                        int codPesquisar = Convert.ToInt32(pesquisar);

                        //Populando dataGridView com informações do banco de dados
                        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
                        conn.Open();
                        NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM manifestacao WHERE cod_manifestante = @cod_manifestante", conn);
                        comando.Parameters.AddWithValue("@cod_manifestante", codPesquisar);
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(comando);
                        DataSet ds = new DataSet();
                        DataTable manifestante = new DataTable();
                        da.Fill(manifestante);
                        dtGrdPesquisa.DataSource = manifestante;
                        conn.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Código não localizado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

            else if (radioButtonProtocolo.Checked)
            {
                try
                {
                    if (maskedTextBoxPesquisa.Text == "")
                    {
                        MessageBox.Show("Preencha o campo de pesquisa", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        maskedTextBoxPesquisa.Select();
                    }
                    else
                    {
                        string pesquisar = maskedTextBoxPesquisa.Text;
                        int codPesquisar = Convert.ToInt32(pesquisar);

                        //Populando dataGridView com informações do banco de dados
                        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
                        conn.Open();
                        NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM manifestacao WHERE cod_manifestacao = @cod_manifestacao", conn);
                        comando.Parameters.AddWithValue("@cod_manifestacao", codPesquisar);
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(comando);
                        DataSet ds = new DataSet();
                        DataTable manifestante = new DataTable();
                        da.Fill(manifestante);
                        dtGrdPesquisa.DataSource = manifestante;
                        conn.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Código não localizado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (radioButtonData.Checked)
            {
                try
                {
                    DateTime dataInicial = dateTimePickerInicial.Value;
                    DateTime dataFinal = dateTimePickerFinal.Value;

                    if(dataFinal < dataInicial)
                    {
                        MessageBox.Show("A data final não pode ser menor que a data inicial!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                                               
                    }

                    else if(dataFinal >= dataInicial)
                    {
                        //Populando dataGridView com informações do banco de dados
                        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
                        conn.Open();
                        NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM manifestacao WHERE data_gravacao BETWEEN @dataInicial AND @dataFinal", conn);
                        comando.Parameters.AddWithValue("@dataInicial", dataInicial);
                        comando.Parameters.AddWithValue("@dataFinal", dataFinal);
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(comando);
                        DataSet ds = new DataSet();
                        DataTable manifestante = new DataTable();
                        da.Fill(manifestante);
                        dtGrdPesquisa.DataSource = manifestante;
                        conn.Close();
                    }                    
                }
                catch
                {
                    MessageBox.Show("Data não localizada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            selecao = dtGrdPesquisa.CurrentRow.Cells[0].Value.ToString();
            cod_selecionado = Convert.ToInt32(selecao);

            //Abrindo a Tela EditarUsuário e levando a variável com o código do usuário selecionado
            View.EditarManifestacao editarManifestacao = new View.EditarManifestacao(cod_selecionado, usuario_logado);
            editarManifestacao.Show();
            this.Close();
        }
    }
}


