namespace TG.View
{
    partial class VisualizaRptManifestante
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
            this.crystalReportViewerManifestante = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.RptManifestante2 = new TG.View.RptManifestante();
            this.RptManifestante1 = new TG.View.RptManifestante();
            this.SuspendLayout();
            // 
            // crystalReportViewerManifestante
            // 
            this.crystalReportViewerManifestante.ActiveViewIndex = 0;
            this.crystalReportViewerManifestante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerManifestante.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerManifestante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerManifestante.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerManifestante.Name = "crystalReportViewerManifestante";
            this.crystalReportViewerManifestante.ReportSource = this.RptManifestante2;
            this.crystalReportViewerManifestante.Size = new System.Drawing.Size(622, 435);
            this.crystalReportViewerManifestante.TabIndex = 0;
            // 
            // VisualizaRptManifestante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 435);
            this.Controls.Add(this.crystalReportViewerManifestante);
            this.Name = "VisualizaRptManifestante";
            this.Text = "Relatório por manifestante";
            this.Load += new System.EventHandler(this.VisualizaRptManifestante_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerManifestante;
        private RptManifestante RptManifestante1;
        private RptManifestante RptManifestante2;
    }
}