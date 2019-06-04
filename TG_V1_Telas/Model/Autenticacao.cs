using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG_V1_Telas.Model
{
    class Autenticacao
    {
        static string usuario;
        static string senha;

        //Metodo de login
        public static void login(string usuario1, string senha1)
        {
            usuario = usuario1;
            senha = senha1;
        }

        //Metodo para pegar os dados do usuario e senha
        public static String getUsuario()
        {
            return "Usuário: " + usuario + "\nSenha:" + senha;
        }
    }
}
