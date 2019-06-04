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
    public partial class RelatorioStatus : Form
    {
        public RelatorioStatus()
        {
            InitializeComponent();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            string status = comboBoxStatus.Text;
            View.VisualizarRptStatus visualizarRptStatus = new VisualizarRptStatus(status);
            visualizarRptStatus.Show();
            this.Close();
        }
    }
}
