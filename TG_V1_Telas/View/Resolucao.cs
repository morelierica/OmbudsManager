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
    public partial class Resolucao : Form
    {

        public Resolucao()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxHora_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxResolucao.Clear();
            comboBoxStatus.SelectedValue = -1;
        }

        private void Resolucao_Load(object sender, EventArgs e)
        {
            dateTimePickerHora.Format = DateTimePickerFormat.Time;
            dateTimePickerHora.ShowUpDown = true;

            dateTimePickerData.Value = DateTime.Now.Date;
            dateTimePickerHora.Value = DateTime.Now;
        }

        private void dateTimePickerHora_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
