using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace TG.Model
{
    class User
    {
        public int cod_usuario;
        public string nome_usuario;
        public DateTime data_nasc_usuario;
        public string cpf_usuario;
        public string login_usuario;
        public string senha_usuario;
                
        //Declaração do metodo de cadastro de usuarios
        public void CadastrarUsuario()
        {
            //Abrindo a conexão com o banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            NpgsqlCommand comando = new NpgsqlCommand();
            comando.Connection = conn;

            NpgsqlCommand comando2 = new NpgsqlCommand();
            comando2.Connection = conn;

            //Comando para inserir código do usuario automaticamente
            comando2.CommandText = "SELECT COUNT(cod_usuario) FROM usuario";
            comando2.ExecuteNonQuery();

            Int32 resultado = Convert.ToInt32(comando2.ExecuteScalar());
            conn.Close();
            resultado = resultado + 1;
            cod_usuario = resultado;

            //Comando para cadastrar usuario
            conn.Open();
            comando.CommandText = "INSERT INTO usuario(cod_usuario, nome_usuario, data_nasc_usuario, cpf_usuario, login_usuario, senha_usuario) VALUES ('" + cod_usuario + "','" + nome_usuario + "', '" + data_nasc_usuario + "', '" + cpf_usuario + "', '" + login_usuario + "', '" + senha_usuario + "' )";
            comando.ExecuteNonQuery();
            conn.Close();
        }

        public void EditarUsuario()
        {
            //Abrindo a conexão com o banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            NpgsqlCommand comando = new NpgsqlCommand();
            comando.Connection = conn;

            //Comando para editar os dados de um usuario ja cadastrado
            comando.CommandText = "UPDATE usuario SET nome_usuario = '" + nome_usuario + "', data_nasc_usuario = '" + data_nasc_usuario + "', cpf_usuario = '" + cpf_usuario + "' WHERE cod_usuario = " + cod_usuario; 
            comando.ExecuteNonQuery();
            conn.Close();
        }

        public void ExcluirUsuario()
        {
            //Abrindo a conexão com o banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            NpgsqlCommand comando = new NpgsqlCommand();
            comando.Connection = conn;

            //Comando para exckuir usuario
            comando.CommandText = "DELETE FROM usuario WHERE cod_usuario = '" + cod_usuario + "'";
            comando.ExecuteNonQuery();
            conn.Close();
        }

        public void EditarSenha()
        {
            //Abrindo a conexão com o banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            NpgsqlCommand comando = new NpgsqlCommand();
            comando.Connection = conn;

            //Comando para editar os dados de um usuario ja cadastrado
            comando.CommandText = "UPDATE usuario SET senha_usuario = '" + senha_usuario + "' WHERE cod_usuario = " + cod_usuario;
            comando.ExecuteNonQuery();
            conn.Close();
        }
    }
}
