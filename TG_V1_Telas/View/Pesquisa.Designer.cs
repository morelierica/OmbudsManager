namespace TG_V1_Telas
{
    partial class Pesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisa));
            this.dtGrdPesquisa = new System.Windows.Forms.DataGridView();
            this.cod_manifestacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setor3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setor4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_gravacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_gravacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prazo_reolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalhamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manifestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonProtocolo = new System.Windows.Forms.RadioButton();
            this.radioButtonData = new System.Windows.Forms.RadioButton();
            this.radioButtonManifestante = new System.Windows.Forms.RadioButton();
            this.maskedTextBoxPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.labelPesquisa = new System.Windows.Forms.Label();
            this.dateTimePickerInicial = new System.Windows.Forms.DateTimePicker();
            this.labelDataInicial = new System.Windows.Forms.Label();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.labelDataFinal = new System.Windows.Forms.Label();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdPesquisa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGrdPesquisa
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGrdPesquisa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrdPesquisa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtGrdPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_manifestacao,
            this.titulo,
            this.prioridade,
            this.tipo,
            this.forma,
            this.setor1,
            this.setor2,
            this.setor3,
            this.setor4,
            this.status,
            this.data_gravacao,
            this.hora_gravacao,
            this.prazo_reolucao,
            this.cod_usuario,
            this.detalhamento,
            this.resolucao,
            this.Manifestante});
            this.dtGrdPesquisa.Location = new System.Drawing.Point(12, 113);
            this.dtGrdPesquisa.Name = "dtGrdPesquisa";
            this.dtGrdPesquisa.Size = new System.Drawing.Size(670, 191);
            this.dtGrdPesquisa.TabIndex = 8;
            // 
            // cod_manifestacao
            // 
            this.cod_manifestacao.DataPropertyName = "cod_manifestacao";
            this.cod_manifestacao.HeaderText = "Protocolo";
            this.cod_manifestacao.Name = "cod_manifestacao";
            this.cod_manifestacao.Width = 80;
            // 
            // titulo
            // 
            this.titulo.DataPropertyName = "titulo";
            this.titulo.HeaderText = "Título";
            this.titulo.Name = "titulo";
            this.titulo.Width = 250;
            // 
            // prioridade
            // 
            this.prioridade.DataPropertyName = "prioridade";
            this.prioridade.HeaderText = "prioridade";
            this.prioridade.Name = "prioridade";
            this.prioridade.Visible = false;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "tipo";
            this.tipo.Name = "tipo";
            this.tipo.Visible = false;
            // 
            // forma
            // 
            this.forma.DataPropertyName = "forma";
            this.forma.HeaderText = "forma";
            this.forma.Name = "forma";
            this.forma.Visible = false;
            // 
            // setor1
            // 
            this.setor1.DataPropertyName = "setor1";
            this.setor1.HeaderText = "setor1";
            this.setor1.Name = "setor1";
            this.setor1.Visible = false;
            // 
            // setor2
            // 
            this.setor2.DataPropertyName = "setor2";
            this.setor2.HeaderText = "setor2";
            this.setor2.Name = "setor2";
            this.setor2.Visible = false;
            // 
            // setor3
            // 
            this.setor3.DataPropertyName = "setor3";
            this.setor3.HeaderText = "setor3";
            this.setor3.Name = "setor3";
            this.setor3.Visible = false;
            // 
            // setor4
            // 
            this.setor4.DataPropertyName = "setor4";
            this.setor4.HeaderText = "setor4";
            this.setor4.Name = "setor4";
            this.setor4.Visible = false;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "status";
            this.status.Name = "status";
            this.status.Visible = false;
            // 
            // data_gravacao
            // 
            this.data_gravacao.DataPropertyName = "data_gravacao";
            this.data_gravacao.HeaderText = "Data";
            this.data_gravacao.Name = "data_gravacao";
            this.data_gravacao.Width = 150;
            // 
            // hora_gravacao
            // 
            this.hora_gravacao.DataPropertyName = "hora_gravacao";
            this.hora_gravacao.HeaderText = "hora_gravacao";
            this.hora_gravacao.Name = "hora_gravacao";
            this.hora_gravacao.Visible = false;
            // 
            // prazo_reolucao
            // 
            this.prazo_reolucao.DataPropertyName = "prazo_reolucao";
            this.prazo_reolucao.HeaderText = "prazo_reolucao";
            this.prazo_reolucao.Name = "prazo_reolucao";
            this.prazo_reolucao.Visible = false;
            // 
            // cod_usuario
            // 
            this.cod_usuario.DataPropertyName = "cod_usuario";
            this.cod_usuario.HeaderText = "cod_usuario";
            this.cod_usuario.Name = "cod_usuario";
            this.cod_usuario.Visible = false;
            // 
            // detalhamento
            // 
            this.detalhamento.DataPropertyName = "detalhamento";
            this.detalhamento.HeaderText = "detalhamento";
            this.detalhamento.Name = "detalhamento";
            this.detalhamento.Visible = false;
            // 
            // resolucao
            // 
            this.resolucao.DataPropertyName = "resolucao";
            this.resolucao.HeaderText = "resolucao";
            this.resolucao.Name = "resolucao";
            this.resolucao.Visible = false;
            // 
            // Manifestante
            // 
            this.Manifestante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manifestante.DataPropertyName = "cod_manifestante";
            this.Manifestante.HeaderText = "Código Manifestante";
            this.Manifestante.Name = "Manifestante";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonProtocolo);
            this.groupBox1.Controls.Add(this.radioButtonData);
            this.groupBox1.Controls.Add(this.radioButtonManifestante);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 82);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por";
            // 
            // radioButtonProtocolo
            // 
            this.radioButtonProtocolo.AutoSize = true;
            this.radioButtonProtocolo.Location = new System.Drawing.Point(7, 48);
            this.radioButtonProtocolo.Name = "radioButtonProtocolo";
            this.radioButtonProtocolo.Size = new System.Drawing.Size(153, 19);
            this.radioButtonProtocolo.TabIndex = 2;
            this.radioButtonProtocolo.TabStop = true;
            this.radioButtonProtocolo.Text = "Protocolo Manifestação";
            this.radioButtonProtocolo.UseVisualStyleBackColor = true;
            this.radioButtonProtocolo.Enter += new System.EventHandler(this.radioButtonProtocolo_Enter);
            // 
            // radioButtonData
            // 
            this.radioButtonData.AutoSize = true;
            this.radioButtonData.Location = new System.Drawing.Point(152, 20);
            this.radioButtonData.Name = "radioButtonData";
            this.radioButtonData.Size = new System.Drawing.Size(51, 19);
            this.radioButtonData.TabIndex = 3;
            this.radioButtonData.TabStop = true;
            this.radioButtonData.Text = "Data";
            this.radioButtonData.UseVisualStyleBackColor = true;
            this.radioButtonData.Enter += new System.EventHandler(this.radioButtonData_Enter);
            // 
            // radioButtonManifestante
            // 
            this.radioButtonManifestante.AutoSize = true;
            this.radioButtonManifestante.Location = new System.Drawing.Point(7, 21);
            this.radioButtonManifestante.Name = "radioButtonManifestante";
            this.radioButtonManifestante.Size = new System.Drawing.Size(138, 19);
            this.radioButtonManifestante.TabIndex = 1;
            this.radioButtonManifestante.TabStop = true;
            this.radioButtonManifestante.Text = "Código Manifestante";
            this.radioButtonManifestante.UseVisualStyleBackColor = true;
            this.radioButtonManifestante.Enter += new System.EventHandler(this.radioButtonManifestante_Enter);
            // 
            // maskedTextBoxPesquisa
            // 
            this.maskedTextBoxPesquisa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxPesquisa.Location = new System.Drawing.Point(311, 48);
            this.maskedTextBoxPesquisa.Name = "maskedTextBoxPesquisa";
            this.maskedTextBoxPesquisa.Size = new System.Drawing.Size(232, 21);
            this.maskedTextBoxPesquisa.TabIndex = 6;
            // 
            // labelPesquisa
            // 
            this.labelPesquisa.AutoSize = true;
            this.labelPesquisa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisa.Location = new System.Drawing.Point(239, 53);
            this.labelPesquisa.Name = "labelPesquisa";
            this.labelPesquisa.Size = new System.Drawing.Size(66, 16);
            this.labelPesquisa.TabIndex = 50;
            this.labelPesquisa.Text = "Pesquisa:";
            // 
            // dateTimePickerInicial
            // 
            this.dateTimePickerInicial.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInicial.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicial.Location = new System.Drawing.Point(245, 57);
            this.dateTimePickerInicial.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerInicial.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerInicial.Name = "dateTimePickerInicial";
            this.dateTimePickerInicial.Size = new System.Drawing.Size(113, 21);
            this.dateTimePickerInicial.TabIndex = 4;
            this.dateTimePickerInicial.Value = new System.DateTime(2019, 6, 5, 0, 0, 0, 0);
            this.dateTimePickerInicial.Visible = false;
            // 
            // labelDataInicial
            // 
            this.labelDataInicial.AutoSize = true;
            this.labelDataInicial.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataInicial.Location = new System.Drawing.Point(242, 38);
            this.labelDataInicial.Name = "labelDataInicial";
            this.labelDataInicial.Size = new System.Drawing.Size(71, 15);
            this.labelDataInicial.TabIndex = 61;
            this.labelDataInicial.Text = "Data Inicial:";
            this.labelDataInicial.Visible = false;
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFinal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFinal.Location = new System.Drawing.Point(376, 57);
            this.dateTimePickerFinal.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerFinal.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(113, 21);
            this.dateTimePickerFinal.TabIndex = 5;
            this.dateTimePickerFinal.Value = new System.DateTime(2019, 6, 5, 0, 0, 0, 0);
            this.dateTimePickerFinal.Visible = false;
            // 
            // labelDataFinal
            // 
            this.labelDataFinal.AutoSize = true;
            this.labelDataFinal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataFinal.Location = new System.Drawing.Point(373, 38);
            this.labelDataFinal.Name = "labelDataFinal";
            this.labelDataFinal.Size = new System.Drawing.Size(66, 15);
            this.labelDataFinal.TabIndex = 63;
            this.labelDataFinal.Text = "Data Final:";
            this.labelDataFinal.Visible = false;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisar.Image = global::TG_V1_Telas.Properties.Resources.procurar;
            this.buttonPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPesquisar.Location = new System.Drawing.Point(583, 38);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(99, 31);
            this.buttonPesquisar.TabIndex = 7;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionar.Image = global::TG_V1_Telas.Properties.Resources.selecionar;
            this.buttonSelecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelecionar.Location = new System.Drawing.Point(299, 328);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(101, 31);
            this.buttonSelecionar.TabIndex = 9;
            this.buttonSelecionar.Text = "Selecionar";
            this.buttonSelecionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 371);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.dateTimePickerFinal);
            this.Controls.Add(this.labelDataFinal);
            this.Controls.Add(this.dateTimePickerInicial);
            this.Controls.Add(this.labelDataInicial);
            this.Controls.Add(this.maskedTextBoxPesquisa);
            this.Controls.Add(this.labelPesquisa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtGrdPesquisa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.Pesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdPesquisa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGrdPesquisa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonProtocolo;
        private System.Windows.Forms.RadioButton radioButtonData;
        private System.Windows.Forms.RadioButton radioButtonManifestante;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPesquisa;
        private System.Windows.Forms.Label labelPesquisa;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicial;
        private System.Windows.Forms.Label labelDataInicial;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        private System.Windows.Forms.Label labelDataFinal;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_manifestacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridade;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn forma;
        private System.Windows.Forms.DataGridViewTextBoxColumn setor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn setor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn setor3;
        private System.Windows.Forms.DataGridViewTextBoxColumn setor4;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_gravacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_gravacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn prazo_reolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalhamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manifestante;
    }
}