using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TG_V1_Telas.Model;

namespace TG_V1_Telas
{
    public partial class TestePg : Form
    {
        string resultado;
        public TestePg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PgSql db = new PgSql();
            resultado = db.Conectar();
            MessageBox.Show(resultado);
        }

        private void TestePg_Load(object sender, EventArgs e)
        {

        }
    }
}
