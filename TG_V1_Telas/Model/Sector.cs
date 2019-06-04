using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace TG_V1_Telas.Model
{
    class Sector
    {
        public int cod_setor;
        public string nome_setor;
        public string coord_setor;
        public string email_coord;

        //Declaração do metodo de cadastro de setores
        public void CadastrarSetor()
        {
            //Abrindo a conexão com o banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            NpgsqlCommand comando = new NpgsqlCommand();
            comando.Connection = conn;

            NpgsqlCommand comando2 = new NpgsqlCommand();
            comando2.Connection = conn;

            //Comando para inserir código do usuario automaticamente
            comando2.CommandText = "SELECT COUNT(cod_setor) FROM setor";
            comando2.ExecuteNonQuery();

            Int32 resultado = Convert.ToInt32(comando2.ExecuteScalar());
            conn.Close();
            resultado = resultado + 1;
            cod_setor = resultado;

            //Comando para cadastrar usuario
            conn.Open();
            comando.CommandText = "INSERT INTO setor(cod_setor, nome_setor, coord_setor, email_coord) VALUES ('" + cod_setor + "','" + nome_setor + "', '" + coord_setor + "', '" + email_coord + "')";
            comando.ExecuteNonQuery();
            conn.Close();
        }

        public void EditarSetor()
        {
            //Abrindo a conexão com o banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            NpgsqlCommand comando = new NpgsqlCommand();
            comando.Connection = conn;

            //Comando para editar os dados de um usuario ja cadastrado
            comando.CommandText = "UPDATE setor SET nome_setor = '" + nome_setor + "', coord_setor = '" + coord_setor + "', email_coord = '" + email_coord + "' WHERE cod_setor = " + cod_setor;
            comando.ExecuteNonQuery();
            conn.Close();
        }

        public void ExcluirSetor()
        {
            //Abrindo a conexão com o banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            NpgsqlCommand comando = new NpgsqlCommand();
            comando.Connection = conn;

            //Comando para exckuir usuario
            comando.CommandText = "DELETE FROM setor WHERE cod_setor = '" + cod_setor + "'";
            comando.ExecuteNonQuery();
            conn.Close();
        }
    }
}