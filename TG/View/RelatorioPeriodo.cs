using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TG.View
{
    public partial class RelatorioPeriodo : Form
    {
        public RelatorioPeriodo()
        {
            InitializeComponent();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {            
            DateTime dataInicial = dateTimePickerDataInicial.Value;
            DateTime dataFinal = dateTimePickerDataFinal.Value;


            View.VisualizarRptPeriodo visualizarRptPeriodo = new VisualizarRptPeriodo(dataInicial, dataFinal);
            visualizarRptPeriodo.Show();
            this.Close();
        }
    }
}
