using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace TG.Model
{
    class Manifestation
    {
        //Atributos da classe manifestacao
        public int cod_manifestacao;
        public int cod_manifestante;
        public string titulo;
        public string prioridade;
        public string tipo;
        public string forma;
        public string setor1;
        public string setor2;
        public string setor3;
        public string setor4;
        public string status;
        public DateTime data_gravacao;
        public DateTime hora_gravacao;
        public DateTime prazo_reolucao;
        public int cod_usuario;
        public string detalhamento;
        public string resolucao;
        
        //Metodo para cadastrar manifestacao
        public void CadastrarManifestacao()
        {
            //Abrindo a conexão com o banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            NpgsqlCommand comando = new NpgsqlCommand();
            comando.Connection = conn;

            NpgsqlCommand comando2 = new NpgsqlCommand();
            comando2.Connection = conn;

            //Comando para inserir código do manifestante automaticamente
            comando2.CommandText = "SELECT COUNT(cod_manifestacao) FROM manifestacao";
            comando2.ExecuteNonQuery();

            Int32 resultado = Convert.ToInt32(comando2.ExecuteScalar());
            conn.Close();
            resultado = resultado + 1;
            cod_manifestacao = resultado;

            //Comando para cadastrar usuario
            conn.Open();
            comando.CommandText = "INSERT INTO manifestacao(cod_manifestacao, cod_manifestante, titulo, prioridade, tipo, forma, setor1, setor2, setor3, setor4, status, data_gravacao, hora_gravacao, prazo_reolucao, cod_usuario, detalhamento, resolucao) VALUES ('" + cod_manifestacao + "','" + cod_manifestante + "','" + titulo + "', '" + prioridade + "', '" + tipo + "', '" + forma + "', '" + setor1 + "','" + setor2 + "','" + setor3 + "','" + setor4 + "','" + status + "','" + data_gravacao + "','" + hora_gravacao + "','" + prazo_reolucao + "','" + cod_usuario + "','" + detalhamento + "','" + resolucao + "' )";
            comando.ExecuteNonQuery();
            conn.Close();
        }

        //Metodo para editar manifestação 
        public void EditarManifestacao()
        {
            //Abrindo a conexão com o banco de dados
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
            conn.Open();

            NpgsqlCommand comando = new NpgsqlCommand();
            comando.Connection = conn;

            //Comando para editar os dados de um usuario ja cadastrado
            comando.CommandText = "UPDATE manifestacao SET cod_manifestacao = '" + cod_manifestacao + "', status = '" + status + "', detalhamento = '" + detalhamento + "', resolucao = '" + resolucao + "' WHERE cod_manifestacao = " + cod_manifestacao;
            comando.ExecuteNonQuery();
            conn.Close();
        }
    }
}
