using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TG_V1_Telas.View
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void buttonNova_Click(object sender, EventArgs e)
        {
            View.CadastroUsuarios cadastroUsuarios = new View.CadastroUsuarios();
            cadastroUsuarios.Show();
            this.Close();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            View.ConsultaUsuario consultaUsuario = new ConsultaUsuario();
            consultaUsuario.Show();
            this.Close();
        }
    }
}
