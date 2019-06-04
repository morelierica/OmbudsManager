using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TG_V1_Telas.View
{
    public partial class VisualizarRptSetor : Form
    {
        public static string setor1;
        public static string setor2;
        public static string setor3;
        public static string setor4;
        public static DateTime dataInicio;
        public static DateTime dataFim;       

        public VisualizarRptSetor()
        {
            InitializeComponent();
        }

        public VisualizarRptSetor(string setor, DateTime dataInicial, DateTime dataFinal)
        {
            InitializeComponent();
            setor1 = setor;
            setor2 = setor;
            setor3 = setor;
            setor4 = setor;
            dataInicio = dataInicial;
            dataFim = dataFinal;            
        }

        private void VisualizarRptSetor_Load(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
                conn.Open();
                NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM manifestacao WHERE (setor1 = @setor1 OR setor2 = @setor2 OR setor3 = @setor3 OR setor4 = @setor4) AND (data_gravacao BETWEEN @dataInicial AND @dataFinal)", conn);
                comando.Parameters.AddWithValue("@setor1", setor1);
                comando.Parameters.AddWithValue("@setor2", setor2);
                comando.Parameters.AddWithValue("@setor3", setor3);
                comando.Parameters.AddWithValue("@setor4", setor4);
                comando.Parameters.AddWithValue("@dataInicial", dataInicio);
                comando.Parameters.AddWithValue("@dataFinal", dataFim);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(comando);
                DataSet ds = new DataSet();
                DataTable manifestacao = new DataTable();
                da.Fill(manifestacao);
                RptSetorTipo rptSetorTipo = new RptSetorTipo();
                rptSetorTipo.SetDataSource(manifestacao);
                crystalReportViewerRptSetor.ReportSource = rptSetorTipo;
                crystalReportViewerRptSetor.Refresh();                

                this.WindowState = FormWindowState.Maximized;
            }
            catch
            {
                MessageBox.Show("PostgreSQL Error!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
