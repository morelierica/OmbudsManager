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
using CrystalDecisions.CrystalReports.Engine;

namespace TG_V1_Telas.View
{
    public partial class VisualizaRptManifestante : Form
    {
        public static int codManifestante;
        public VisualizaRptManifestante()
        {
            InitializeComponent();
        }

        public VisualizaRptManifestante(int codigo)
        {
            InitializeComponent();
            codManifestante = codigo;
        }

        private void VisualizaRptManifestante_Load(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=@postgre; Database=ouvidoria;");
                conn.Open();
                NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM manifestacao WHERE cod_manifestante = @cod_manifestante", conn);
                comando.Parameters.AddWithValue("@cod_manifestante", codManifestante);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(comando);
                DataSet ds = new DataSet();
                DataTable manifestacao = new DataTable();
                da.Fill(manifestacao);
                RptManifestante rptManifestante = new RptManifestante();
                rptManifestante.SetDataSource(manifestacao);
                crystalReportViewerManifestante.ReportSource = rptManifestante;
                crystalReportViewerManifestante.Refresh();                               

                this.WindowState = FormWindowState.Maximized;
            }
            catch
            {
                MessageBox.Show("PostgreSQL Error!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
