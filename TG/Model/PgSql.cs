/* Classe de conexão com o banco de dados */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace TG.Model
{
    class PgSql
    {
        //String de conexao
        public string conexaoString = "Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;";

        // Objeto de conexao
        public NpgsqlConnection conexao;

        //Metodo de conexao
        public string Conectar()
        {
            string retorno;
            this.conexao = new NpgsqlConnection(this.conexaoString);

            try
            {
                this.conexao.Open();
                retorno = "Conectado ao banco de dados!";
            }
            catch
            {
                retorno = "Não foi possivel fazer a conexão com o banco de dados";
            }
            finally
            {
                this.conexao.Close();
            }

            return retorno;
        }
    }
}
