using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace TG_V1_Telas.Model
{
    class Protester
    {
        //Atributos da classe manifestante
        public int cod_manifestante;
        public string nome_manifestante;
        public string nome_mae;
        public string email_manifestante;
        public DateTime data_nasc_manifestante;
        public string cpf_manifestante;
        public string celular_manifestante;
        public string telefone_manifestante;
        public string convenio_manifestante;
        public string rua_manifestante;
        public string bairro_manifestante;
        public string numero_manifestante;
        public string cidade_manifestante;
        public string cep_manifestante;
        public string uf_manifestante;
        public string observacoes_manifestante;

        //Metodo para cadastrar manifestante
        public void CadastrarManifestante()
        {
            //Abrindo a conexão com o banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            NpgsqlCommand comando = new NpgsqlCommand();
            comando.Connection = conn;

            NpgsqlCommand comando2 = new NpgsqlCommand();
            comando2.Connection = conn;

            //Comando para inserir código do manifestante automaticamente
            comando2.CommandText = "SELECT COUNT(cod_manifestante) FROM manifestante";
            comando2.ExecuteNonQuery();

            Int32 resultado = Convert.ToInt32(comando2.ExecuteScalar());
            conn.Close();
            resultado = resultado + 1;
            cod_manifestante = resultado;

            //Comando para cadastrar usuario
            conn.Open();
            comando.CommandText = "INSERT INTO manifestante(cod_manifestante, nome_manifestante, nome_mae, email_manifestante, data_nasc_manifestante, cpf_manifestante, celular_manifestante, telefone_manifestante, convenio_manifestante, rua_manifestante, bairro_manifestante, numero_manifestante, cidade_manifestante, cep_manifestante, uf_manifestante, observacoes_manifestante) VALUES ('" + cod_manifestante + "','" + nome_manifestante + "', '" + nome_mae + "', '" + email_manifestante + "', '" + data_nasc_manifestante + "', '" + cpf_manifestante + "','" + celular_manifestante + "','" + telefone_manifestante + "','" + convenio_manifestante + "','" + rua_manifestante + "','" + bairro_manifestante + "','" + numero_manifestante + "','" + cidade_manifestante + "','" + cep_manifestante + "','" + uf_manifestante + "','" + observacoes_manifestante + "' )";
            comando.ExecuteNonQuery();
            conn.Close();
        }

        public void EditarManifestante()
        {
            //Abrindo a conexão com o banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            NpgsqlCommand comando = new NpgsqlCommand();
            comando.Connection = conn;

            //Comando para editar os dados de um usuario ja cadastrado
            comando.CommandText = "UPDATE manifestante SET nome_manifestante = '" + nome_manifestante + "', nome_mae = '" + nome_mae + "', email_manifestante = '" + email_manifestante + "', data_nasc_manifestante = '" + data_nasc_manifestante + "', cpf_manifestante = '" + cpf_manifestante + "', celular_manifestante = '" + celular_manifestante + "', telefone_manifestante = '" + telefone_manifestante + "', convenio_manifestante = '" + convenio_manifestante + "', rua_manifestante = '" + rua_manifestante + "', bairro_manifestante = '" + bairro_manifestante + "', numero_manifestante = '" + numero_manifestante + "', cidade_manifestante = '" + cidade_manifestante + "', cep_manifestante = '" + cep_manifestante + "', uf_manifestante = '" + uf_manifestante + "', observacoes_manifestante = '" + observacoes_manifestante + "' WHERE cod_manifestante = " + cod_manifestante;
            comando.ExecuteNonQuery();
            conn.Close();
        }
    }
}