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
    public partial class ConsultaUsuario : Form
    {
        public ConsultaUsuario()
        {
            InitializeComponent();
        }

        private void dataGridViewUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Variáveis globais que armazenam o código do usuário selecionado
        public string selecao;
        public int cod_selecionado;

        private void ConsultaUsuario_Load(object sender, EventArgs e)
        {
            //Populando dataGridView com informações do banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM usuario ORDER BY cod_usuario", conn);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(comando);

            DataSet ds = new DataSet();

            DataTable usuario = new DataTable();

            da.Fill(usuario);

            dataGridViewUsuario.DataSource = usuario;
            conn.Close();

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            selecao = dataGridViewUsuario.CurrentRow.Cells[0].Value.ToString();
            cod_selecionado = Convert.ToInt32(selecao);

            //Abrindo a Tela EditarUsuário e levando a variável com o código do usuário selecionado
            View.EditarUsuario editarUsuario = new View.EditarUsuario(cod_selecionado);
            editarUsuario.Show();
            this.Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o usuário selecionado?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            
            if (result == DialogResult.OK)
            {
                selecao = dataGridViewUsuario.CurrentRow.Cells[0].Value.ToString();
                cod_selecionado = Convert.ToInt32(selecao);

                User user = new User();
                user.cod_usuario = cod_selecionado;

                //Chamando Método que exclui usuario
                user.ExcluirUsuario();

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
