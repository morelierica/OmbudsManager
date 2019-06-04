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

namespace TG_V1_Telas.View
{
    public partial class VisualizarRptStatus : Form
    {
        public static string statusSelecionado;

        public VisualizarRptStatus()
        {
            InitializeComponent();
        }

        public VisualizarRptStatus(string status)
        {
            InitializeComponent();
            statusSelecionado = status;
        }
        
        private void VisualizarRptStatus_Load(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
                conn.Open();
                NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM manifestacao WHERE status = @status", conn);
                comando.Parameters.AddWithValue("@status", statusSelecionado);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(comando);
                DataSet ds = new DataSet();
                DataTable manifestacao = new DataTable();
                da.Fill(manifestacao);
                RptStatus rptStatus = new RptStatus();                            
                rptStatus.SetDataSource(manifestacao);
                crystalReportViewerStatus.ReportSource = rptStatus;
                crystalReportViewerStatus.Refresh();

                this.WindowState = FormWindowState.Maximized;
            }
            catch
            {
                MessageBox.Show("PostgreSQL Error!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
