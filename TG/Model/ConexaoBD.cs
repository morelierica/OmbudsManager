using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace TG.Model
{
    class ConexaoBD
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");

        //Conectar
        public void Conectar()
        {
            conn.Open();
        }

        //Desconectar
        public void Desconectar()
        {
            conn.Close();
        }

    }
}
