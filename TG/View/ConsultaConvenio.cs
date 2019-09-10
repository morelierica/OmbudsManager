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
    public partial class ConsultaConvenio : Form
    {
        public ConsultaConvenio()
        {
            InitializeComponent();
        }

        //Variáveis globais que armazenam o código do convenio selecionado
        public string selecao;
        public int cod_selecionado;

        private void ConsultaConvenio_Load(object sender, EventArgs e)
        {
            //Populando dataGridView com informações do banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM convenio ORDER BY nome_convenio", conn);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(comando);

            DataSet ds = new DataSet();

            DataTable convenio = new DataTable();

            da.Fill(convenio);

            dataGridViewConvenio.DataSource = convenio;
            conn.Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o usuário selecionado?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (result == DialogResult.OK)
            {
                selecao = dataGridViewConvenio.CurrentRow.Cells[0].Value.ToString();
                cod_selecionado = Convert.ToInt32(selecao);

                Convenant convenant = new Convenant();
                convenant.cod_convenio = cod_selecionado;

                //Chamando Método que exclui usuario
                convenant.ExcluirConvenio();                

                MessageBox.Show("Usuário excluido com sucesso!", "Usuário Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Operação cancelada, o usuário não será excluído", "Operação Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
