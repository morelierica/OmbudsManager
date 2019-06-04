namespace TG_V1_Telas.View
{
    partial class VisualizarRptPeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarRptPeriodo));
            this.crystalReportViewerPeriodo = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.RptPeriodo1 = new TG_V1_Telas.View.RptPeriodo();
            this.SuspendLayout();
            // 
            // crystalReportViewerPeriodo
            // 
            this.crystalReportViewerPeriodo.ActiveViewIndex = 0;
            this.crystalReportViewerPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerPeriodo.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerPeriodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerPeriodo.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerPeriodo.Name = "crystalReportViewerPeriodo";
            this.crystalReportViewerPeriodo.ReportSource = this.RptPeriodo1;
            this.crystalReportViewerPeriodo.Size = new System.Drawing.Size(855, 546);
            this.crystalReportViewerPeriodo.TabIndex = 0;
            this.crystalReportViewerPeriodo.Load += new System.EventHandler(this.crystalReportViewerPeriodo_Load);
            // 
            // VisualizarRptPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(855, 546);
            this.Controls.Add(this.crystalReportViewerPeriodo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisualizarRptPeriodo";
            this.Text = "Relatório por período";
            this.Load += new System.EventHandler(this.VisualizarRptPeriodo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerPeriodo;
        private RptPeriodo RptPeriodo1;
    }
}