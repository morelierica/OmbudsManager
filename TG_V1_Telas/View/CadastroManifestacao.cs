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
    public partial class CadastroManifestacao : Form
    {
        public CadastroManifestacao()
        {
            InitializeComponent();
        }

        public static string usuario = "";
        //Puxando o código do manifestante do outro Form 
        public CadastroManifestacao(int codigo_usuario, string usuarioLogado)
        {
            InitializeComponent();
            textBoxCodigo.Text = codigo_usuario.ToString();
            int codigo_manifestante = codigo_usuario;
            usuario = usuarioLogado;
            textBoxUsuarioLogado.Text = usuario;

            //Verificar qual manifestante selecionado e preencher as textBox com as informações dele 
            //query para pegar os dados do usuario no banco de dados
            String query = "SELECT * FROM manifestante WHERE cod_manifestante=@cod_manifestante";

            //Abrindo a conexão com o banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            //Executando a query
            NpgsqlCommand comando = new NpgsqlCommand(query, conn);

            //Atribuindo o código na variável da query
            comando.Parameters.AddWithValue("@cod_manifestante", codigo_manifestante);

            //Leitor do banco de dados
            NpgsqlDataReader leitor = comando.ExecuteReader();

            if (leitor.Read())
            {
                //Preenchendo as textbox com os dados do manifestante pesquisado
                string nome = leitor["nome_manifestante"].ToString();
                textBoxNome.Text = nome;

                string dataNasc = leitor["data_nasc_manifestante"].ToString();
                dateTimePickerDataNasc.Text = dataNasc;

                string convenio = leitor["convenio_manifestante"].ToString();
                textBoxConvenio.Text = convenio;
            }
            else
            {
                MessageBox.Show("Erro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CadastroManifestacao_Load(object sender, EventArgs e)
        {
            dateTimePickerHora.Format = DateTimePickerFormat.Time;
            dateTimePickerHora.ShowUpDown = true;
            dateTimePickerHora.Value = DateTime.Now;
            textBoxTitulo.Select();

            this.dateTimePickerData.Value = DateTime.Now.Date;
            this.dateTimePickerPrazo.Value = DateTime.Now.Date;

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

                this.comboBoxSetor1.DataSource = table; //atribui o objeto DataTable a instancia SQL a ser conectada
                this.comboBoxSetor1.ValueMember = "cod_setor"; //Obtenção do valor do membro (código do convenio)
                this.comboBoxSetor1.DisplayMember = "nome_setor"; //Obtenção do nome do membro
                              
                reader.Close();
                reader.Dispose();


                NpgsqlCommand comando2 = new NpgsqlCommand();
                comando2.Connection = conn;
                comando2.CommandText = "SELECT cod_setor, nome_setor FROM setor ORDER BY nome_setor ASC";
                NpgsqlDataReader reader2 = comando2.ExecuteReader(); //retorna dados resultantes da consulta SQL
                DataTable table2 = new DataTable(); //estrutura da tabela do banco de dados
                table2.Load(reader2); //carrega dados na tabela de acordo com a instrução SQL passada
                DataRow row2 = table2.NewRow(); //representa uma linha de dados em um DataTable
                row2["nome_setor"] = ""; //para não gerar valor nulo e evitar erro de execução
                table2.Rows.InsertAt(row2, 0); //Insere nova linha na coleção no local especificado

                this.comboBoxSetor2.DataSource = table2; //atribui o objeto DataTable a instancia SQL a ser conectada
                this.comboBoxSetor2.ValueMember = "cod_setor"; //Obtenção do valor do membro (código do convenio)
                this.comboBoxSetor2.DisplayMember = "nome_setor"; //Obtenção do nome do membro

                reader2.Close();
                reader2.Dispose();

                NpgsqlCommand comando3 = new NpgsqlCommand();
                comando3.Connection = conn;
                comando3.CommandText = "SELECT cod_setor, nome_setor FROM setor ORDER BY nome_setor ASC";
                NpgsqlDataReader reader3 = comando3.ExecuteReader(); //retorna dados resultantes da consulta SQL
                DataTable table3 = new DataTable(); //estrutura da tabela do banco de dados
                table3.Load(reader3); //carrega dados na tabela de acordo com a instrução SQL passada
                DataRow row3 = table3.NewRow(); //representa uma linha de dados em um DataTable
                row3["nome_setor"] = ""; //para não gerar valor nulo e evitar erro de execução
                table3.Rows.InsertAt(row3, 0); //Insere nova linha na coleção no local especificado

                this.comboBoxSetor3.DataSource = table3; //atribui o objeto DataTable a instancia SQL a ser conectada
                this.comboBoxSetor3.ValueMember = "cod_setor"; //Obtenção do valor do membro (código do convenio)
                this.comboBoxSetor3.DisplayMember = "nome_setor"; //Obtenção do nome do membro

                reader3.Close();
                reader3.Dispose();

                NpgsqlCommand comando4 = new NpgsqlCommand();
                comando4.Connection = conn;
                comando4.CommandText = "SELECT cod_setor, nome_setor FROM setor ORDER BY nome_setor ASC";
                NpgsqlDataReader reader4 = comando3.ExecuteReader(); //retorna dados resultantes da consulta SQL
                DataTable table4 = new DataTable(); //estrutura da tabela do banco de dados
                table4.Load(reader4); //carrega dados na tabela de acordo com a instrução SQL passada
                DataRow row4 = table4.NewRow(); //representa uma linha de dados em um DataTable
                row4["nome_setor"] = ""; //para não gerar valor nulo e evitar erro de execução
                table4.Rows.InsertAt(row4, 0); //Insere nova linha na coleção no local especificado

                this.comboBoxSetor4.DataSource = table4; //atribui o objeto DataTable a instancia SQL a ser conectada
                this.comboBoxSetor4.ValueMember = "cod_setor"; //Obtenção do valor do membro (código do convenio)
                this.comboBoxSetor4.DisplayMember = "nome_setor"; //Obtenção do nome do membro

                reader4.Close();
                reader4.Dispose();
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string cod = "";
            int codInteiro;
            //Verificar qual manifestante selecionado e preencher as textBox com as informações dele 
            //query para pegar os dados do usuario no banco de dados
            String query = "SELECT * FROM usuario WHERE nome_usuario=@nome_usuario";

            //Abrindo a conexão com o banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            //Executando a query
            NpgsqlCommand comando = new NpgsqlCommand(query, conn);

            //Atribuindo o código na variável da query
            comando.Parameters.AddWithValue("@nome_usuario", usuario);

            //Leitor do banco de dados
            NpgsqlDataReader leitor = comando.ExecuteReader();

            if (leitor.Read())
            {
                //Preenchendo as textbox com os dados do manifestante pesquisado
                cod = leitor["cod_usuario"].ToString();                
            }
            else
            {
                MessageBox.Show("Erro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            codInteiro = Convert.ToInt32(cod);
        
            //Validações de preenchimento
            if(textBoxTitulo.TextLength <=0 || comboBoxPrioridade.Text == "" || comboBoxTipo.Text == "" || comboBoxForma.Text == "" || comboBoxSetor1.Text == "" || textBoxDetalhamento.TextLength <= 0)
            {
                MessageBox.Show("Todos os campos marcados com '*' devem ser preenchidos!", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Aqui será utilizado o método CadastrarManifestacao
            else
            {
                //Inserindo os valores aos atributos da classe Manifestacao (Manifestation)
                Manifestation manifestation = new Manifestation();

                manifestation.cod_manifestante = Convert.ToInt32(textBoxCodigo.Text);
                manifestation.titulo = textBoxTitulo.Text;
                manifestation.prioridade = comboBoxPrioridade.Text;
                manifestation.tipo = comboBoxTipo.Text;
                manifestation.forma = comboBoxForma.Text;
                manifestation.setor1 = comboBoxSetor1.Text;
                manifestation.setor2 = comboBoxSetor2.Text;
                manifestation.setor3 = comboBoxSetor3.Text;
                manifestation.setor4 = comboBoxSetor4.Text;
                manifestation.status = comboBoxStatus.Text;
                manifestation.data_gravacao = dateTimePickerData.Value;
                manifestation.hora_gravacao = dateTimePickerHora.Value;
                manifestation.prazo_reolucao = dateTimePickerPrazo.Value;
                manifestation.cod_usuario = codInteiro;
                manifestation.detalhamento = textBoxDetalhamento.Text;
                manifestation.resolucao = textBoxResolucao.Text;

                //Chamando metodo cadastrarManifestacao
                manifestation.CadastrarManifestacao();
                                
                MessageBox.Show("Manifestação cadastrada com sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
