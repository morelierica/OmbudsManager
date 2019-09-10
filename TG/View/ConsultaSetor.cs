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
    public partial class ConsultaSetor : Form
    {
        public ConsultaSetor()
        {
            InitializeComponent();
        }
        
        //Variáveis globais que armazenam o código do setor selecionado
        public string selecao;
        public int cod_selecionado;

        private void ConsultaSetor_Load(object sender, EventArgs e)
        {
            //Populando dataGridView com informações do banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM setor ORDER BY nome_setor", conn);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(comando);

            DataSet ds = new DataSet();

            DataTable setor = new DataTable();

            da.Fill(setor);

            dataGridViewSetor.DataSource = setor;
            conn.Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            selecao = dataGridViewSetor.CurrentRow.Cells[0].Value.ToString();
            cod_selecionado = Convert.ToInt32(selecao);

            //Abrindo a Tela EditarSetor e levando a variável com o código do setor selecionado
            View.EditarSetor editarSetor = new View.EditarSetor(cod_selecionado);
            editarSetor.Show();
            this.Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o setor selecionado?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (result == DialogResult.OK)
            {
                selecao = dataGridViewSetor.CurrentRow.Cells[0].Value.ToString();
                cod_selecionado = Convert.ToInt32(selecao);

                Sector sector = new Sector();
                sector.cod_setor = cod_selecionado;

                //Chamando Método que exclui setor
                sector.ExcluirSetor();                

                MessageBox.Show("Setor excluido com sucesso!", "Usuário Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Operação cancelada, o usuário não será excluído", "Operação Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
