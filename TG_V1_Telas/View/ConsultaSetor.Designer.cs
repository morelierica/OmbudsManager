namespace TG_V1_Telas.View
{
    partial class ConsultaSetor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaSetor));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSetor = new System.Windows.Forms.DataGridView();
            this.cod_setor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_setor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coord_setor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_coord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSetor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 59;
            this.label1.Text = "Setores Cadastrados:";
            // 
            // dataGridViewSetor
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewSetor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSetor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSetor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSetor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSetor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_setor,
            this.nome_setor,
            this.coord_setor,
            this.email_coord});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSetor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSetor.Location = new System.Drawing.Point(12, 42);
            this.dataGridViewSetor.Name = "dataGridViewSetor";
            this.dataGridViewSetor.Size = new System.Drawing.Size(600, 206);
            this.dataGridViewSetor.TabIndex = 58;
            // 
            // cod_setor
            // 
            this.cod_setor.DataPropertyName = "cod_setor";
            this.cod_setor.HeaderText = "Código";
            this.cod_setor.Name = "cod_setor";
            // 
            // nome_setor
            // 
            this.nome_setor.DataPropertyName = "nome_setor";
            this.nome_setor.HeaderText = "Nome";
            this.nome_setor.Name = "nome_setor";
            this.nome_setor.Width = 300;
            // 
            // coord_setor
            // 
            this.coord_setor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coord_setor.DataPropertyName = "coord_setor";
            this.coord_setor.HeaderText = "Coordenador(a)";
            this.coord_setor.Name = "coord_setor";
            // 
            // email_coord
            // 
            this.email_coord.DataPropertyName = "email_coord";
            this.email_coord.HeaderText = "E-mail Coordenado(a)";
            this.email_coord.Name = "email_coord";
            this.email_coord.Visible = false;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Image = global::TG_V1_Telas.Properties.Resources.edit;
            this.buttonEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditar.Location = new System.Drawing.Point(231, 281);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(79, 31);
            this.buttonEditar.TabIndex = 61;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.Image = global::TG_V1_Telas.Properties.Resources.cancelar;
            this.buttonExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluir.Location = new System.Drawing.Point(316, 281);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(79, 31);
            this.buttonExcluir.TabIndex = 60;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // ConsultaSetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 333);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSetor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaSetor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaSetor";
            this.Load += new System.EventHandler(this.ConsultaSetor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSetor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSetor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_setor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_setor;
        private System.Windows.Forms.DataGridViewTextBoxColumn coord_setor;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_coord;
    }
}