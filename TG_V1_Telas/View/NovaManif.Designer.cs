﻿namespace TG_V1_Telas
{
    partial class NovaManif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaManif));
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.buttonNova = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.BackColor = System.Drawing.Color.Transparent;
            this.buttonConsultar.BackgroundImage = global::TG_V1_Telas.Properties.Resources.pesquisar;
            this.buttonConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConsultar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.Location = new System.Drawing.Point(271, 61);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(90, 90);
            this.buttonConsultar.TabIndex = 1;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonConsultar.UseVisualStyleBackColor = false;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // buttonNova
            // 
            this.buttonNova.BackColor = System.Drawing.Color.Transparent;
            this.buttonNova.BackgroundImage = global::TG_V1_Telas.Properties.Resources.novo;
            this.buttonNova.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNova.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNova.Location = new System.Drawing.Point(149, 61);
            this.buttonNova.Name = "buttonNova";
            this.buttonNova.Size = new System.Drawing.Size(90, 90);
            this.buttonNova.TabIndex = 0;
            this.buttonNova.Text = "Nova";
            this.buttonNova.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNova.UseVisualStyleBackColor = false;
            this.buttonNova.Click += new System.EventHandler(this.buttonNova_Click);
            // 
            // NovaManif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 225);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.buttonNova);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NovaManif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manifestação";
            this.Load += new System.EventHandler(this.NovaManif_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNova;
        private System.Windows.Forms.Button buttonConsultar;
    }
}