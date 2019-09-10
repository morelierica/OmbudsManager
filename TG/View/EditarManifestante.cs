using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TG.Model;
using Npgsql;
using CpfLibrary;

namespace TG.View
{
    public partial class EditarManifestante : Form
    {
        int cod_manifestante; 

        public EditarManifestante()
        {
            InitializeComponent();
        }

        public EditarManifestante(int codManifestante)
        {
            InitializeComponent();
            cod_manifestante = codManifestante;
        }

        private void EditarManifestante_Load(object sender, EventArgs e)
        {
            textBoxNome.Select();

            maskedTextBoxCpf.Mask = "000,000,000-00";
            maskedTextBoxCelular.Mask = "(00)0 0000-0000";
            maskedTextBoxTelefone.Mask = "(00)0000-0000";
            maskedTextBoxCep.Mask = "00,000-000";
            textBoxNome.Select();

            //Preencher comboBox Convênio
            //Abrindo a conexão com o banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();
            try
            {
                NpgsqlCommand comando2 = new NpgsqlCommand();
                comando2.Connection = conn;
                comando2.CommandText = "SELECT cod_convenio, nome_convenio FROM convenio ORDER BY nome_convenio ASC";
                NpgsqlDataReader reader = comando2.ExecuteReader(); //retorna dados resultantes da consulta SQL
                DataTable table = new DataTable(); //estrutura da tabela do banco de dados
                table.Load(reader); //carrega dados na tabela de acordo com a instrução SQL passada
                DataRow row = table.NewRow(); //representa uma linha de dados em um DataTable
                row["nome_convenio"] = ""; //para não gerar valor nulo e evitar erro de execução
                table.Rows.InsertAt(row, 0); //Insere nova linha na coleção no local especificado

                this.comboBoxConvenio.DataSource = table; //atribui o objeto DataTable a instancia SQL a ser conectada
                this.comboBoxConvenio.ValueMember = "cod_convenio"; //Obtenção do valor do membro (código do convenio)
                this.comboBoxConvenio.DisplayMember = "nome_convenio"; //Obtenção do nome do membro

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
            }

            //Verificar qual o manifestante selecionado para editar e preencher as textBox com as informações dele

            //query para pegar os dados do usuario no banco de dados
            String query = "SELECT * FROM manifestante WHERE cod_manifestante=@cod_manifestante";
            
            conn.Open();

            //Executando a query
            NpgsqlCommand comando = new NpgsqlCommand(query, conn);    

            //Atribuindo o código na variável da query
            comando.Parameters.AddWithValue("@cod_manifestante", cod_manifestante);

            //Leitor do banco de dados
            NpgsqlDataReader leitor = comando.ExecuteReader();

            if (leitor.Read())
            {
                //Preenchendo as textbox com os dados do usuário pesquisado
                string cod = leitor["cod_manifestante"].ToString();
                textBoxCodigo.Text = cod;

                string nome = leitor["nome_manifestante"].ToString();
                textBoxNome.Text = nome;

                string nome_mae = leitor["nome_mae"].ToString();
                textBoxNomeMae.Text = nome_mae;

                string email = leitor["email_manifestante"].ToString();
                textBoxEmail.Text = email;             

                string data = leitor["data_nasc_manifestante"].ToString();
                dateTimePickerDataNasc.Text = data;

                string cpf = leitor["cpf_manifestante"].ToString();
                maskedTextBoxCpf.Text = cpf;

                string celular = leitor["celular_manifestante"].ToString();
                maskedTextBoxCelular.Text = celular;

                string telefone = leitor["telefone_manifestante"].ToString();
                maskedTextBoxTelefone.Text = telefone;

                string convenio = leitor["convenio_manifestante"].ToString();
                comboBoxConvenio.Text = convenio;

                string cep = leitor["cep_manifestante"].ToString();
                maskedTextBoxCep.Text = cep;

                string rua = leitor["rua_manifestante"].ToString();
                textBoxRua.Text = rua;

                string numero = leitor["numero_manifestante"].ToString();
                textBoxNumero.Text = numero;

                string bairro = leitor["bairro_manifestante"].ToString();
                textBoxBairro.Text = bairro;

                string cidade = leitor["cidade_manifestante"].ToString();
                textBoxCidade.Text = cidade;

                string uf = leitor["uf_manifestante"].ToString();
                comboBoxUf.Text = uf;

                string obs = leitor["observacoes_manifestante"].ToString();
                textBoxObs.Text = obs;
            }
            else
            {
                MessageBox.Show("Erro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            //Validações de preenchimento do cadastro
            string dataValidacao = DateTime.Now.AddYears(-16).ToShortDateString();
            DateTime dataValida = Convert.ToDateTime(DateTime.Now.AddYears(-16).ToShortDateString());

            if (textBoxNome.TextLength <= 0 || textBoxNomeMae.TextLength <= 0 || maskedTextBoxCpf.TextLength <= 0 || maskedTextBoxCelular.TextLength <= 0 || comboBoxConvenio.Text == "" || textBoxRua.TextLength <= 0 || textBoxBairro.TextLength <= 0 || textBoxNumero.TextLength <= 0 || textBoxCidade.TextLength <= 0 || comboBoxUf.Text == "")
            {
                MessageBox.Show("Todos os campos marcados com '*' devem ser preenchidos!", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Aqui será utilizado o metodo CadastrarManifestante da classe Protester
            else if (Convert.ToDateTime(dateTimePickerDataNasc.Text) >= Convert.ToDateTime(dataValidacao))
            {
                MessageBox.Show("Idade do manifestante deve ser superior a 16 anos.", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Inserindo os valores aos atributos da classe Manifestante (Protester)
                Protester protester = new Protester();

                protester.cod_manifestante = cod_manifestante;
                protester.nome_manifestante = textBoxNome.Text;
                protester.nome_mae = textBoxNomeMae.Text;
                protester.email_manifestante = textBoxEmail.Text;
                protester.data_nasc_manifestante = dateTimePickerDataNasc.Value;
                protester.cpf_manifestante = maskedTextBoxCpf.Text;
                protester.celular_manifestante = maskedTextBoxCelular.Text;
                protester.telefone_manifestante = maskedTextBoxTelefone.Text;
                protester.telefone_manifestante = maskedTextBoxTelefone.Text;
                protester.rua_manifestante = textBoxRua.Text;
                protester.bairro_manifestante = textBoxBairro.Text;
                protester.numero_manifestante = textBoxNumero.Text;
                protester.cidade_manifestante = textBoxCidade.Text;
                protester.cep_manifestante = maskedTextBoxCep.Text;
                protester.uf_manifestante = comboBoxUf.Text;
                protester.observacoes_manifestante = textBoxObs.Text;
                protester.convenio_manifestante = comboBoxConvenio.Text;

                //Chamando o metodo CadastrarManifestante
                protester.EditarManifestante();
                MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            maskedTextBoxCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            try
            {
                CEP cep = new CEP(maskedTextBoxCep.Text);
                textBoxRua.Text = cep.logradouro;
                textBoxBairro.Text = cep.bairro;
                textBoxCidade.Text = cep.localidade;
                comboBoxUf.Text = cep.uf;
                textBoxNumero.Select();
            }
            catch
            {
                MessageBox.Show("CEP Inválido", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTextBoxCep.Clear();
                maskedTextBoxCep.Select();
            }
        }

        private void maskedTextBoxCpf_Leave(object sender, EventArgs e)
        {
            Boolean resposta = Cpf.Check(maskedTextBoxCpf.Text);

            if (resposta == false)
            {
                MessageBox.Show("Digite um CPF válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTextBoxCpf.Clear();
                maskedTextBoxCpf.Select();
            }
        }
    }
}
