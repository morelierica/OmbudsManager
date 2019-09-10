namespace TG
{
    partial class Manifestacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manifestacao));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCodigo = new System.Windows.Forms.RadioButton();
            this.radioButtonDocumento = new System.Windows.Forms.RadioButton();
            this.radioButtonData = new System.Windows.Forms.RadioButton();
            this.radioButtonNome = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonNovoManif = new System.Windows.Forms.Button();
            this.dataGridViewManifestante = new System.Windows.Forms.DataGridView();
            this.cod_manifestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_manifestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_mae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_manifestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf_manifestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular_manifestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone_manifestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.convenio_manifestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rua_manifestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro_manifestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_manifestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade_manifestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep_manifestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf_manifestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoes_manifestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_nasc_manifestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTextBoxPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManifestante)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCodigo);
            this.groupBox1.Controls.Add(this.radioButtonDocumento);
            this.groupBox1.Controls.Add(this.radioButtonData);
            this.groupBox1.Controls.Add(this.radioButtonNome);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por";
            // 
            // radioButtonCodigo
            // 
            this.radioButtonCodigo.AutoSize = true;
            this.radioButtonCodigo.Location = new System.Drawing.Point(7, 48);
            this.radioButtonCodigo.Name = "radioButtonCodigo";
            this.radioButtonCodigo.Size = new System.Drawing.Size(65, 19);
            this.radioButtonCodigo.TabIndex = 3;
            this.radioButtonCodigo.TabStop = true;
            this.radioButtonCodigo.Text = "Código";
            this.radioButtonCodigo.UseVisualStyleBackColor = true;
            this.radioButtonCodigo.Enter += new System.EventHandler(this.radioButtonCodigo_Enter);
            // 
            // radioButtonDocumento
            // 
            this.radioButtonDocumento.AutoSize = true;
            this.radioButtonDocumento.Location = new System.Drawing.Point(133, 22);
            this.radioButtonDocumento.Name = "radioButtonDocumento";
            this.radioButtonDocumento.Size = new System.Drawing.Size(89, 19);
            this.radioButtonDocumento.TabIndex = 2;
            this.radioButtonDocumento.TabStop = true;
            this.radioButtonDocumento.Text = "Documento";
            this.radioButtonDocumento.UseVisualStyleBackColor = true;
            this.radioButtonDocumento.Enter += new System.EventHandler(this.radioButtonDocumento_Enter);
            // 
            // radioButtonData
            // 
            this.radioButtonData.AutoSize = true;
            this.radioButtonData.Location = new System.Drawing.Point(133, 47);
            this.radioButtonData.Name = "radioButtonData";
            this.radioButtonData.Size = new System.Drawing.Size(136, 19);
            this.radioButtonData.TabIndex = 1;
            this.radioButtonData.TabStop = true;
            this.radioButtonData.Text = "Data de nascimento";
            this.radioButtonData.UseVisualStyleBackColor = true;
            this.radioButtonData.Enter += new System.EventHandler(this.radioButtonData_Enter);
            // 
            // radioButtonNome
            // 
            this.radioButtonNome.AutoSize = true;
            this.radioButtonNome.Location = new System.Drawing.Point(7, 21);
            this.radioButtonNome.Name = "radioButtonNome";
            this.radioButtonNome.Size = new System.Drawing.Size(59, 19);
            this.radioButtonNome.TabIndex = 0;
            this.radioButtonNome.TabStop = true;
            this.radioButtonNome.Text = "Nome";
            this.radioButtonNome.UseVisualStyleBackColor = true;
            this.radioButtonNome.Enter += new System.EventHandler(this.radioButtonNome_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisa Manifestante:";
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionar.Image = global::TG.Properties.Resources.selecionar;
            this.buttonSelecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelecionar.Location = new System.Drawing.Point(299, 335);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(101, 31);
            this.buttonSelecionar.TabIndex = 42;
            this.buttonSelecionar.Text = "Selecionar";
            this.buttonSelecionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisar.Image = global::TG.Properties.Resources.procurar;
            this.buttonPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPesquisar.Location = new System.Drawing.Point(377, 65);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(99, 33);
            this.buttonPesquisar.TabIndex = 41;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // buttonNovoManif
            // 
            this.buttonNovoManif.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovoManif.Image = global::TG.Properties.Resources.novoUsuario;
            this.buttonNovoManif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNovoManif.Location = new System.Drawing.Point(482, 65);
            this.buttonNovoManif.Name = "buttonNovoManif";
            this.buttonNovoManif.Size = new System.Drawing.Size(142, 33);
            this.buttonNovoManif.TabIndex = 40;
            this.buttonNovoManif.Text = "Novo Manifestante";
            this.buttonNovoManif.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNovoManif.UseVisualStyleBackColor = true;
            this.buttonNovoManif.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewManifestante
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewManifestante.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewManifestante.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewManifestante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManifestante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_manifestante,
            this.nome_manifestante,
            this.nome_mae,
            this.email_manifestante,
            this.cpf_manifestante,
            this.celular_manifestante,
            this.telefone_manifestante,
            this.convenio_manifestante,
            this.rua_manifestante,
            this.bairro_manifestante,
            this.numero_manifestante,
            this.cidade_manifestante,
            this.cep_manifestante,
            this.uf_manifestante,
            this.observacoes_manifestante,
            this.data_nasc_manifestante});
            this.dataGridViewManifestante.Location = new System.Drawing.Point(12, 118);
            this.dataGridViewManifestante.Name = "dataGridViewManifestante";
            this.dataGridViewManifestante.Size = new System.Drawing.Size(671, 211);
            this.dataGridViewManifestante.TabIndex = 47;
            // 
            // cod_manifestante
            // 
            this.cod_manifestante.DataPropertyName = "cod_manifestante";
            this.cod_manifestante.HeaderText = "Código";
            this.cod_manifestante.Name = "cod_manifestante";
            this.cod_manifestante.Width = 120;
            // 
            // nome_manifestante
            // 
            this.nome_manifestante.DataPropertyName = "nome_manifestante";
            this.nome_manifestante.HeaderText = "Nome";
            this.nome_manifestante.Name = "nome_manifestante";
            this.nome_manifestante.Width = 350;
            // 
            // nome_mae
            // 
            this.nome_mae.DataPropertyName = "nome_mae";
            this.nome_mae.HeaderText = "Nome mae";
            this.nome_mae.Name = "nome_mae";
            this.nome_mae.Visible = false;
            // 
            // email_manifestante
            // 
            this.email_manifestante.DataPropertyName = "email_manifestante";
            this.email_manifestante.HeaderText = "Email";
            this.email_manifestante.Name = "email_manifestante";
            this.email_manifestante.Visible = false;
            // 
            // cpf_manifestante
            // 
            this.cpf_manifestante.DataPropertyName = "cpf_manifestante";
            this.cpf_manifestante.HeaderText = "CPF";
            this.cpf_manifestante.Name = "cpf_manifestante";
            this.cpf_manifestante.Visible = false;
            // 
            // celular_manifestante
            // 
            this.celular_manifestante.DataPropertyName = "celular_manifestante";
            this.celular_manifestante.HeaderText = "celular";
            this.celular_manifestante.Name = "celular_manifestante";
            this.celular_manifestante.Visible = false;
            // 
            // telefone_manifestante
            // 
            this.telefone_manifestante.DataPropertyName = "telefone_manifestante";
            this.telefone_manifestante.HeaderText = "telefone";
            this.telefone_manifestante.Name = "telefone_manifestante";
            this.telefone_manifestante.Visible = false;
            // 
            // convenio_manifestante
            // 
            this.convenio_manifestante.DataPropertyName = "convenio_manifestante";
            this.convenio_manifestante.HeaderText = "convenio";
            this.convenio_manifestante.Name = "convenio_manifestante";
            this.convenio_manifestante.Visible = false;
            // 
            // rua_manifestante
            // 
            this.rua_manifestante.DataPropertyName = "rua_manifestante";
            this.rua_manifestante.HeaderText = "rua";
            this.rua_manifestante.Name = "rua_manifestante";
            this.rua_manifestante.Visible = false;
            // 
            // bairro_manifestante
            // 
            this.bairro_manifestante.DataPropertyName = "bairro_manifestante";
            this.bairro_manifestante.HeaderText = "bairro";
            this.bairro_manifestante.Name = "bairro_manifestante";
            this.bairro_manifestante.Visible = false;
            // 
            // numero_manifestante
            // 
            this.numero_manifestante.DataPropertyName = "numero_manifestante";
            this.numero_manifestante.HeaderText = "numero";
            this.numero_manifestante.Name = "numero_manifestante";
            this.numero_manifestante.Visible = false;
            // 
            // cidade_manifestante
            // 
            this.cidade_manifestante.DataPropertyName = "cidade_manifestante";
            this.cidade_manifestante.HeaderText = "cidade";
            this.cidade_manifestante.Name = "cidade_manifestante";
            this.cidade_manifestante.Visible = false;
            // 
            // cep_manifestante
            // 
            this.cep_manifestante.DataPropertyName = "cep_manifestante";
            this.cep_manifestante.HeaderText = "cep";
            this.cep_manifestante.Name = "cep_manifestante";
            this.cep_manifestante.Visible = false;
            // 
            // uf_manifestante
            // 
            this.uf_manifestante.DataPropertyName = "uf_manifestante";
            this.uf_manifestante.HeaderText = "uf";
            this.uf_manifestante.Name = "uf_manifestante";
            this.uf_manifestante.Visible = false;
            // 
            // observacoes_manifestante
            // 
            this.observacoes_manifestante.DataPropertyName = "observacoes_manifestante";
            this.observacoes_manifestante.HeaderText = "obs";
            this.observacoes_manifestante.Name = "observacoes_manifestante";
            this.observacoes_manifestante.Visible = false;
            // 
            // data_nasc_manifestante
            // 
            this.data_nasc_manifestante.DataPropertyName = "data_nasc_manifestante";
            this.data_nasc_manifestante.HeaderText = "Data de nascimento";
            this.data_nasc_manifestante.Name = "data_nasc_manifestante";
            this.data_nasc_manifestante.Width = 158;
            // 
            // maskedTextBoxPesquisa
            // 
            this.maskedTextBoxPesquisa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxPesquisa.Location = new System.Drawing.Point(302, 37);
            this.maskedTextBoxPesquisa.Name = "maskedTextBoxPesquisa";
            this.maskedTextBoxPesquisa.Size = new System.Drawing.Size(381, 21);
            this.maskedTextBoxPesquisa.TabIndex = 48;
            // 
            // Manifestacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 378);
            this.Controls.Add(this.maskedTextBoxPesquisa);
            this.Controls.Add(this.dataGridViewManifestante);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.buttonNovoManif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Manifestacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manifestacao";
            this.Load += new System.EventHandler(this.Manifestacao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManifestante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCodigo;
        private System.Windows.Forms.RadioButton radioButtonDocumento;
        private System.Windows.Forms.RadioButton radioButtonData;
        private System.Windows.Forms.RadioButton radioButtonNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNovoManif;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.DataGridView dataGridViewManifestante;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_manifestante;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_manifestante;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_mae;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_manifestante;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf_manifestante;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular_manifestante;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone_manifestante;
        private System.Windows.Forms.DataGridViewTextBoxColumn convenio_manifestante;
        private System.Windows.Forms.DataGridViewTextBoxColumn rua_manifestante;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro_manifestante;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_manifestante;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade_manifestante;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep_manifestante;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf_manifestante;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoes_manifestante;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_nasc_manifestante;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPesquisa;
    }
}