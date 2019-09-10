namespace TG.View
{
    partial class VisualizarRptSetor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewerRptSetor = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.RptSetorTipo1 = new TG.View.RptSetorTipo();
            this.SuspendLayout();
            // 
            // crystalReportViewerRptSetor
            // 
            this.crystalReportViewerRptSetor.ActiveViewIndex = 0;
            this.crystalReportViewerRptSetor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerRptSetor.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerRptSetor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerRptSetor.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerRptSetor.Name = "crystalReportViewerRptSetor";
            this.crystalReportViewerRptSetor.ReportSource = this.RptSetorTipo1;
            this.crystalReportViewerRptSetor.Size = new System.Drawing.Size(1050, 443);
            this.crystalReportViewerRptSetor.TabIndex = 0;
            this.crystalReportViewerRptSetor.Load += new System.EventHandler(this.crystalReportViewerRptSetor_Load);
            // 
            // VisualizarRptSetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 443);
            this.Controls.Add(this.crystalReportViewerRptSetor);
            this.Name = "VisualizarRptSetor";
            this.Text = "Relatório por setor e tipo";
            this.Load += new System.EventHandler(this.VisualizarRptSetor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerRptSetor;
        private View.RptSetorTipo RptSetorTipo1;
    }
}