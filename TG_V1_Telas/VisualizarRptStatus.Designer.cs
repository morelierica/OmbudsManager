namespace TG_V1_Telas.View
{
    partial class VisualizarRptStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarRptStatus));
            this.crystalReportViewerStatus = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.RptStatus1 = new TG_V1_Telas.View.RptStatus();
            this.SuspendLayout();
            // 
            // crystalReportViewerStatus
            // 
            this.crystalReportViewerStatus.ActiveViewIndex = 0;
            this.crystalReportViewerStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerStatus.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerStatus.Name = "crystalReportViewerStatus";
            this.crystalReportViewerStatus.ReportSource = this.RptStatus1;
            this.crystalReportViewerStatus.Size = new System.Drawing.Size(762, 482);
            this.crystalReportViewerStatus.TabIndex = 0;            
            // 
            // VisualizarRptStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 482);
            this.Controls.Add(this.crystalReportViewerStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisualizarRptStatus";
            this.Text = "Relatório por status";
            this.Load += new System.EventHandler(this.VisualizarRptStatus_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerStatus;
        private RptStatus RptStatus1;
    }
}