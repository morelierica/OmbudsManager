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
    public partial class EditarManifestacao : Form
    {
        public EditarManifestacao()
        {
            InitializeComponent();
        }
        public EditarManifestacao(int cod_manifestacao, string cod_usuario)
        {
            InitializeComponent();
            textBoxProtocolo.Text = cod_manifestacao.ToString();
            textBoxUsuario.Text = cod_usuario;
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja salvar as alterações?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (result == DialogResult.OK)
            {
                Manifestation manifestation = new Manifestation();
                
                int codInteiro = Convert.ToInt32(textBoxProtocolo.Text);
                manifestation.cod_manifestacao = codInteiro;
                manifestation.status = comboBoxStatus.Text;
                manifestation.detalhamento = textBoxDetalhamento.Text;
                manifestation.resolucao = textBoxResolucao.Text;

                manifestation.EditarManifestacao();
                
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

        private void EditarManifestacao_Load(object sender, EventArgs e)
        {
            dateTimePickerHora.Format = DateTimePickerFormat.Time;
            dateTimePickerHora.ShowUpDown = true;
            dateTimePickerHora.Value = DateTime.Now;
            this.dateTimePickerData.Value = DateTime.Now.Date;
            textBoxDetalhamento.Select();

            //Verificar qual manifestação selecionada para editar e preencher as textBox com as informações dela
            //query para pegar os dados da manifestação no banco de dados
            String query = "SELECT * FROM manifestacao WHERE cod_manifestacao=@cod_manifestacao";

            //Abrindo a conexão com o banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            //Executando a query
            NpgsqlCommand comando = new NpgsqlCommand(query, conn);

            //Transformando o código de string para inteiro
            int codigoInteiro = Convert.ToInt32(textBoxProtocolo.Text);

            //Atribuindo o código na variável da query
            comando.Parameters.AddWithValue("@cod_manifestacao", codigoInteiro);

            //Leitor do banco de dados
            NpgsqlDataReader leitor = comando.ExecuteReader();

            if (leitor.Read())
            {
                //Preenchendo as textbox com os dados do usuário pesquisado
                string cod_manifestante = leitor["cod_manifestante"].ToString();
                textBoxCodigo.Text = cod_manifestante;

                string titulo = leitor["titulo"].ToString();
                textBoxTitulo.Text = titulo;

                string prioridade = leitor["prioridade"].ToString();
                comboBoxPrioridade.Text = prioridade;

                string tipo = leitor["tipo"].ToString();
                comboBoxTipo.Text = tipo;

                string forma = leitor["forma"].ToString();
                comboBoxForma.Text = forma;

                string setor1 = leitor["setor1"].ToString();
                comboBoxSetor1.Text = setor1;

                string setor2 = leitor["setor2"].ToString();
                comboBoxSetor2.Text = setor2;

                string setor3 = leitor["setor3"].ToString();
                comboBoxSetor3.Text = setor3;

                string setor4 = leitor["setor4"].ToString();
                comboBoxSetor4.Text = setor4;

                string status = leitor["status"].ToString();
                comboBoxStatus.Text = status;

                string detalhamento = leitor["detalhamento"].ToString();
                textBoxDetalhamento.Text = detalhamento;

                string resolucao = leitor["resolucao"].ToString();
                textBoxResolucao.Text = resolucao;

                string prazo_reolucao = leitor["prazo_reolucao"].ToString();
                dateTimePickerPrazo.Text = prazo_reolucao;

                conn.Close();
            }
            else
            {
                MessageBox.Show("Erro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Verificar qual manifestante selecionado para preencher os dados dele
            //query para pegar os dados do manifestante no banco de dados
            String query2 = "SELECT * FROM manifestante WHERE cod_manifestante=@cod_manifestante";

            conn.Open();

            //Executando a query
            NpgsqlCommand comando2 = new NpgsqlCommand(query2, conn);

            //Transformando o código de string para inteiro
            int codigoInteiro2 = Convert.ToInt32(textBoxCodigo.Text);

            //Atribuindo o código na variável da query
            comando2.Parameters.AddWithValue("@cod_manifestante", codigoInteiro2);

            //Leitor do banco de dados
            NpgsqlDataReader leitor2 = comando2.ExecuteReader();

            if (leitor2.Read())
            {
                //Preenchendo as textbox com os dados do usuário pesquisado
                string nome_manifestante = leitor2["nome_manifestante"].ToString();
                textBoxNome.Text = nome_manifestante;

                string data_nasc = leitor2["data_nasc_manifestante"].ToString();
                dateTimePickerDataNasc.Text = data_nasc;

                string convenio = leitor2["convenio_manifestante"].ToString();
                textBoxConvenio.Text = convenio;
            }
            else
            {
                MessageBox.Show("PostgreSQL Error!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
