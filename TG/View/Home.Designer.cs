namespace TG
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manifestaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convêniosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manifestaçõesPorPeríodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manifestaçõesPorStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manifestaçõesPorManifestanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manifestaçõesPorSetorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonManifestacao = new System.Windows.Forms.Button();
            this.buttonManifestante = new System.Windows.Forms.Button();
            this.textBoxUsuarioLogado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.labelManifestacao = new System.Windows.Forms.Label();
            this.labelManifestante = new System.Windows.Forms.Label();
            this.labelF1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manifestaçãoToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.relatóriosToolStripMenuItem1,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manifestaçãoToolStripMenuItem
            // 
            this.manifestaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.convêniosToolStripMenuItem});
            this.manifestaçãoToolStripMenuItem.Name = "manifestaçãoToolStripMenuItem";
            this.manifestaçãoToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.manifestaçãoToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.cadastrarToolStripMenuItem.Text = "Usuários";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.consultarToolStripMenuItem.Text = "Setores";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // convêniosToolStripMenuItem
            // 
            this.convêniosToolStripMenuItem.Name = "convêniosToolStripMenuItem";
            this.convêniosToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.convêniosToolStripMenuItem.Text = "Convênios";
            this.convêniosToolStripMenuItem.Click += new System.EventHandler(this.convêniosToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarSenhaToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.relatóriosToolStripMenuItem.Text = "Utilitário";
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            this.alterarSenhaToolStripMenuItem.Click += new System.EventHandler(this.alterarSenhaToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem1
            // 
            this.relatóriosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manifestaçõesPorPeríodoToolStripMenuItem,
            this.manifestaçõesPorStatusToolStripMenuItem,
            this.manifestaçõesPorManifestanteToolStripMenuItem,
            this.manifestaçõesPorSetorToolStripMenuItem});
            this.relatóriosToolStripMenuItem1.Name = "relatóriosToolStripMenuItem1";
            this.relatóriosToolStripMenuItem1.Size = new System.Drawing.Size(78, 20);
            this.relatóriosToolStripMenuItem1.Text = "Relatórios";
            // 
            // manifestaçõesPorPeríodoToolStripMenuItem
            // 
            this.manifestaçõesPorPeríodoToolStripMenuItem.Name = "manifestaçõesPorPeríodoToolStripMenuItem";
            this.manifestaçõesPorPeríodoToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.manifestaçõesPorPeríodoToolStripMenuItem.Text = "Manifestações por período";
            this.manifestaçõesPorPeríodoToolStripMenuItem.Click += new System.EventHandler(this.manifestaçõesPorPeríodoToolStripMenuItem_Click);
            // 
            // manifestaçõesPorStatusToolStripMenuItem
            // 
            this.manifestaçõesPorStatusToolStripMenuItem.Name = "manifestaçõesPorStatusToolStripMenuItem";
            this.manifestaçõesPorStatusToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.manifestaçõesPorStatusToolStripMenuItem.Text = "Manifestações por status";
            this.manifestaçõesPorStatusToolStripMenuItem.Click += new System.EventHandler(this.manifestaçõesPorStatusToolStripMenuItem_Click);
            // 
            // manifestaçõesPorManifestanteToolStripMenuItem
            // 
            this.manifestaçõesPorManifestanteToolStripMenuItem.Name = "manifestaçõesPorManifestanteToolStripMenuItem";
            this.manifestaçõesPorManifestanteToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.manifestaçõesPorManifestanteToolStripMenuItem.Text = "Manifestações por manifestante";
            this.manifestaçõesPorManifestanteToolStripMenuItem.Click += new System.EventHandler(this.manifestaçõesPorManifestanteToolStripMenuItem_Click);
            // 
            // manifestaçõesPorSetorToolStripMenuItem
            // 
            this.manifestaçõesPorSetorToolStripMenuItem.Name = "manifestaçõesPorSetorToolStripMenuItem";
            this.manifestaçõesPorSetorToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.manifestaçõesPorSetorToolStripMenuItem.Text = "Manifestações por setor e tipo";
            this.manifestaçõesPorSetorToolStripMenuItem.Click += new System.EventHandler(this.manifestaçõesPorSetorToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDoSistemaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.MouseEnter += new System.EventHandler(this.ajudaToolStripMenuItem_MouseEnter);
            this.ajudaToolStripMenuItem.MouseLeave += new System.EventHandler(this.ajudaToolStripMenuItem_MouseLeave);
            // 
            // manualDoSistemaToolStripMenuItem
            // 
            this.manualDoSistemaToolStripMenuItem.Name = "manualDoSistemaToolStripMenuItem";
            this.manualDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.manualDoSistemaToolStripMenuItem.Text = "Manual do sistema";
            this.manualDoSistemaToolStripMenuItem.Click += new System.EventHandler(this.manualDoSistemaToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // buttonManifestacao
            // 
            this.buttonManifestacao.BackgroundImage = global::TG.Properties.Resources.manifestacao;
            this.buttonManifestacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonManifestacao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManifestacao.Location = new System.Drawing.Point(0, 24);
            this.buttonManifestacao.Name = "buttonManifestacao";
            this.buttonManifestacao.Size = new System.Drawing.Size(100, 100);
            this.buttonManifestacao.TabIndex = 1;
            this.buttonManifestacao.Text = "Manifestação";
            this.buttonManifestacao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonManifestacao.UseVisualStyleBackColor = true;
            this.buttonManifestacao.Click += new System.EventHandler(this.button1_Click);
            this.buttonManifestacao.MouseEnter += new System.EventHandler(this.buttonManifestacao_MouseEnter);
            this.buttonManifestacao.MouseLeave += new System.EventHandler(this.buttonManifestacao_MouseLeave);
            // 
            // buttonManifestante
            // 
            this.buttonManifestante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonManifestante.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManifestante.Image = global::TG.Properties.Resources.manifestante;
            this.buttonManifestante.Location = new System.Drawing.Point(98, 24);
            this.buttonManifestante.Name = "buttonManifestante";
            this.buttonManifestante.Size = new System.Drawing.Size(100, 100);
            this.buttonManifestante.TabIndex = 2;
            this.buttonManifestante.Text = "Manifestante";
            this.buttonManifestante.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonManifestante.UseVisualStyleBackColor = true;
            this.buttonManifestante.Click += new System.EventHandler(this.buttonManifestante_Click);
            this.buttonManifestante.MouseEnter += new System.EventHandler(this.buttonManifestante_MouseEnter);
            this.buttonManifestante.MouseLeave += new System.EventHandler(this.buttonManifestante_MouseLeave);
            // 
            // textBoxUsuarioLogado
            // 
            this.textBoxUsuarioLogado.Enabled = false;
            this.textBoxUsuarioLogado.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuarioLogado.Location = new System.Drawing.Point(410, 2);
            this.textBoxUsuarioLogado.Name = "textBoxUsuarioLogado";
            this.textBoxUsuarioLogado.Size = new System.Drawing.Size(231, 20);
            this.textBoxUsuarioLogado.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuário:";
            // 
            // buttonSair
            // 
            this.buttonSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSair.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Image = global::TG.Properties.Resources.desligar;
            this.buttonSair.Location = new System.Drawing.Point(197, 24);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(100, 100);
            this.buttonSair.TabIndex = 6;
            this.buttonSair.Text = "Sair";
            this.buttonSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click_1);
            // 
            // labelManifestacao
            // 
            this.labelManifestacao.AutoSize = true;
            this.labelManifestacao.BackColor = System.Drawing.Color.Transparent;
            this.labelManifestacao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManifestacao.Location = new System.Drawing.Point(34, 127);
            this.labelManifestacao.Name = "labelManifestacao";
            this.labelManifestacao.Size = new System.Drawing.Size(31, 16);
            this.labelManifestacao.TabIndex = 7;
            this.labelManifestacao.Text = "(F8)";
            this.labelManifestacao.Visible = false;
            // 
            // labelManifestante
            // 
            this.labelManifestante.AutoSize = true;
            this.labelManifestante.BackColor = System.Drawing.Color.Transparent;
            this.labelManifestante.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManifestante.Location = new System.Drawing.Point(130, 127);
            this.labelManifestante.Name = "labelManifestante";
            this.labelManifestante.Size = new System.Drawing.Size(31, 16);
            this.labelManifestante.TabIndex = 8;
            this.labelManifestante.Text = "(F9)";
            this.labelManifestante.Visible = false;
            // 
            // labelF1
            // 
            this.labelF1.AutoSize = true;
            this.labelF1.BackColor = System.Drawing.SystemColors.Control;
            this.labelF1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelF1.Location = new System.Drawing.Point(280, 4);
            this.labelF1.Name = "labelF1";
            this.labelF1.Size = new System.Drawing.Size(31, 16);
            this.labelF1.TabIndex = 9;
            this.labelF1.Text = "(F1)";
            this.labelF1.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TG.Properties.Resources.plano;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.labelF1);
            this.Controls.Add(this.labelManifestante);
            this.Controls.Add(this.labelManifestacao);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUsuarioLogado);
            this.Controls.Add(this.buttonManifestante);
            this.Controls.Add(this.buttonManifestacao);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Home_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manifestaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDoSistemaToolStripMenuItem;
        private System.Windows.Forms.Button buttonManifestacao;
        private System.Windows.Forms.Button buttonManifestante;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convêniosToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxUsuarioLogado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manifestaçõesPorPeríodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manifestaçõesPorStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manifestaçõesPorManifestanteToolStripMenuItem;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private System.Windows.Forms.Label labelManifestacao;
        private System.Windows.Forms.Label labelManifestante;
        private System.Windows.Forms.ToolStripMenuItem manifestaçõesPorSetorToolStripMenuItem;
        private System.Windows.Forms.Label labelF1;
    }
}