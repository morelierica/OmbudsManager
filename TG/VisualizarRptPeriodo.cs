using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Npgsql;
using CrystalDecisions.CrystalReports.Engine;

namespace TG.View
{
    public partial class VisualizarRptPeriodo : Form
    {
        public static DateTime dataInicial;
        public static DateTime dataFinal;

        public VisualizarRptPeriodo()
        {
            InitializeComponent();
        }

        public VisualizarRptPeriodo(DateTime dataInicio, DateTime dataFim)
        {
            InitializeComponent();
            dataInicial = dataInicio;
            dataFinal = dataFim;         
        }

        private void VisualizarRptPeriodo_Load(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
                conn.Open();
                NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM manifestacao WHERE data_gravacao BETWEEN @dataInicial AND @dataFinal", conn);
                comando.Parameters.AddWithValue("@dataInicial", dataInicial);
                comando.Parameters.AddWithValue("@dataFinal", dataFinal);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(comando);
                DataSet ds = new DataSet();
                DataTable manifestacao = new DataTable();
                da.Fill(manifestacao);
                RptPeriodo rptPeriodo = new RptPeriodo();
                rptPeriodo.SetDataSource(manifestacao);
                crystalReportViewerPeriodo.ReportSource = rptPeriodo;
                crystalReportViewerPeriodo.Refresh();

                this.WindowState = FormWindowState.Maximized;
            }
            catch
            {
                MessageBox.Show("PostgreSQL Error!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void crystalReportViewerPeriodo_Load(object sender, EventArgs e)
        {

        }
    }
}
