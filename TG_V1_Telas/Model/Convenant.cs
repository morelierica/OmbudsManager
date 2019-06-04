using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace TG_V1_Telas.Model
{
    class Convenant
    {
        public int cod_convenio;
        public string nome_convenio;

        //Declaração do método para cadastrar o Convenio

        public void CadastrarConvenio()
        {
            //Abrindo a conexão com o banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            NpgsqlCommand comando = new NpgsqlCommand();
            comando.Connection = conn;

            NpgsqlCommand comando2 = new NpgsqlCommand();
            comando2.Connection = conn;

            //Comando para inserir código do usuario automaticamente
            comando2.CommandText = "SELECT COUNT(cod_convenio) FROM convenio";
            comando2.ExecuteNonQuery();

            Int32 resultado = Convert.ToInt32(comando2.ExecuteScalar());
            conn.Close();
            resultado = resultado + 1;
            cod_convenio = resultado;

            //Comando para cadastrar usuario
            conn.Open();
            comando.CommandText = "INSERT INTO convenio(cod_convenio, nome_convenio) VALUES ('" + cod_convenio + "','" + nome_convenio + "')";
            comando.ExecuteNonQuery();
            conn.Close();
        }

        //Declaração do método para preencher combobox com os convenios cadastrados no BD
        public void PreencherConvenio()
        {
            
        }

        public void ExcluirConvenio()
        {
            //Abrindo a conexão com o banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            NpgsqlCommand comando = new NpgsqlCommand();
            comando.Connection = conn;

            //Comando para exckuir usuario
            comando.CommandText = "DELETE FROM convenio WHERE cod_convenio = '" + cod_convenio + "'";
            comando.ExecuteNonQuery();
            conn.Close();
        }
    }
}
