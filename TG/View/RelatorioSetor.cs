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

namespace TG.View
{
    public partial class RelatorioSetor : Form
    {
        public RelatorioSetor()
        {
            InitializeComponent();
        }

        private void RelatorioSetor_Load(object sender, EventArgs e)
        {
            //Preencher comboBox Setor
            //Abrindo a conexão com o banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            try
            {
                NpgsqlCommand comando = new NpgsqlCommand();
                comando.Connection = conn;
                comando.CommandText = "SELECT cod_setor, nome_setor FROM setor ORDER BY nome_setor ASC";
                NpgsqlDataReader reader = comando.ExecuteReader(); //retorna dados resultantes da consulta SQL
                DataTable table = new DataTable(); //estrutura da tabela do banco de dados
                table.Load(reader); //carrega dados na tabela de acordo com a instrução SQL passada
                DataRow row = table.NewRow(); //representa uma linha de dados em um DataTable
                row["nome_setor"] = ""; //para não gerar valor nulo e evitar erro de execução
                table.Rows.InsertAt(row, 0); //Insere nova linha na coleção no local especificado

                this.comboBoxSetor.DataSource = table; //atribui o objeto DataTable a instancia SQL a ser conectada
                this.comboBoxSetor.ValueMember = "cod_setor"; //Obtenção do valor do membro (código do convenio)
                this.comboBoxSetor.DisplayMember = "nome_setor"; //Obtenção do nome do membro                

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

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {                    
            //Parâmetros que serão passados para a tela VisualizarRptSetor
            string setor = comboBoxSetor.Text;
            DateTime dataInicial = dateTimePickerDataInicial.Value;
            DateTime dataFinal = dateTimePickerDataFinal.Value;

            View.VisualizarRptSetor visualizarRptSetor = new VisualizarRptSetor(setor, dataInicial, dataFinal);
            visualizarRptSetor.Show();
            this.Close();
        }
    }
}