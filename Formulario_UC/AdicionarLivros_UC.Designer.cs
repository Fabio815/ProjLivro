namespace ProjLivro.Formulario_UC
{
    partial class AdicionarLivros_UC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarLivros_UC));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.abrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dg_livros = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_grid = new System.Windows.Forms.GroupBox();
            this.gb_formulario = new System.Windows.Forms.GroupBox();
            this.lbl_quantidadeLivros = new System.Windows.Forms.Label();
            this.tb_quantidadeLivro = new System.Windows.Forms.TextBox();
            this.cmb_generoLivro = new System.Windows.Forms.ComboBox();
            this.lbl_generoLivro = new System.Windows.Forms.Label();
            this.lbl_precoLivro = new System.Windows.Forms.Label();
            this.tb_precoLivro = new System.Windows.Forms.TextBox();
            this.lbl_nomeEditora = new System.Windows.Forms.Label();
            this.tb_nomeEditora = new System.Windows.Forms.TextBox();
            this.tb_nomeAutor = new System.Windows.Forms.TextBox();
            this.lbl_nomeAutor = new System.Windows.Forms.Label();
            this.tb_nomeLivro = new System.Windows.Forms.TextBox();
            this.lbl_nomeLivro = new System.Windows.Forms.Label();
            this.tb_codigoLivro = new System.Windows.Forms.TextBox();
            this.lbl_codigoLivro = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_livros)).BeginInit();
            this.gb_grid.SuspendLayout();
            this.gb_formulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripButton,
            this.abrirToolStripButton,
            this.toolStripSeparator1,
            this.copiarToolStripButton,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(717, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.salvarToolStripButton.Text = "&Salvar";
            this.salvarToolStripButton.Click += new System.EventHandler(this.salvarToolStripButton_Click);
            // 
            // abrirToolStripButton
            // 
            this.abrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripButton.Image")));
            this.abrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripButton.Name = "abrirToolStripButton";
            this.abrirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.abrirToolStripButton.Text = "&Abrir";
            this.abrirToolStripButton.Click += new System.EventHandler(this.abrirToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // copiarToolStripButton
            // 
            this.copiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copiarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripButton.Image")));
            this.copiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripButton.Name = "copiarToolStripButton";
            this.copiarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copiarToolStripButton.Text = "&Copiar";
            this.copiarToolStripButton.Click += new System.EventHandler(this.copiarToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::ProjLivro.Properties.Resources.fechar;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::ProjLivro.Properties.Resources.limpar_limpo;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // dg_livros
            // 
            this.dg_livros.AllowUserToAddRows = false;
            this.dg_livros.AllowUserToDeleteRows = false;
            this.dg_livros.AllowUserToOrderColumns = true;
            this.dg_livros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_livros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nomeLivro,
            this.qdt});
            this.dg_livros.Location = new System.Drawing.Point(6, 13);
            this.dg_livros.Name = "dg_livros";
            this.dg_livros.ReadOnly = true;
            this.dg_livros.Size = new System.Drawing.Size(364, 259);
            this.dg_livros.TabIndex = 15;
            // 
            // Id
            // 
            this.Id.HeaderText = "Código Livro";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 90;
            // 
            // nomeLivro
            // 
            this.nomeLivro.HeaderText = "Nome do Livro";
            this.nomeLivro.Name = "nomeLivro";
            this.nomeLivro.ReadOnly = true;
            this.nomeLivro.Width = 150;
            // 
            // qdt
            // 
            this.qdt.HeaderText = "Quantidade de Livros";
            this.qdt.Name = "qdt";
            this.qdt.ReadOnly = true;
            this.qdt.Width = 80;
            // 
            // gb_grid
            // 
            this.gb_grid.Controls.Add(this.dg_livros);
            this.gb_grid.Location = new System.Drawing.Point(330, 46);
            this.gb_grid.Name = "gb_grid";
            this.gb_grid.Size = new System.Drawing.Size(376, 287);
            this.gb_grid.TabIndex = 16;
            this.gb_grid.TabStop = false;
            this.gb_grid.Text = "groupBox1";
            // 
            // gb_formulario
            // 
            this.gb_formulario.Controls.Add(this.lbl_quantidadeLivros);
            this.gb_formulario.Controls.Add(this.tb_quantidadeLivro);
            this.gb_formulario.Controls.Add(this.cmb_generoLivro);
            this.gb_formulario.Controls.Add(this.lbl_generoLivro);
            this.gb_formulario.Controls.Add(this.lbl_precoLivro);
            this.gb_formulario.Controls.Add(this.tb_precoLivro);
            this.gb_formulario.Controls.Add(this.lbl_nomeEditora);
            this.gb_formulario.Controls.Add(this.tb_nomeEditora);
            this.gb_formulario.Controls.Add(this.tb_nomeAutor);
            this.gb_formulario.Controls.Add(this.lbl_nomeAutor);
            this.gb_formulario.Controls.Add(this.tb_nomeLivro);
            this.gb_formulario.Controls.Add(this.lbl_nomeLivro);
            this.gb_formulario.Controls.Add(this.tb_codigoLivro);
            this.gb_formulario.Controls.Add(this.lbl_codigoLivro);
            this.gb_formulario.Location = new System.Drawing.Point(3, 46);
            this.gb_formulario.Name = "gb_formulario";
            this.gb_formulario.Size = new System.Drawing.Size(321, 287);
            this.gb_formulario.TabIndex = 17;
            this.gb_formulario.TabStop = false;
            this.gb_formulario.Text = "groupBox2";
            // 
            // lbl_quantidadeLivros
            // 
            this.lbl_quantidadeLivros.AutoSize = true;
            this.lbl_quantidadeLivros.Location = new System.Drawing.Point(196, 168);
            this.lbl_quantidadeLivros.Name = "lbl_quantidadeLivros";
            this.lbl_quantidadeLivros.Size = new System.Drawing.Size(35, 13);
            this.lbl_quantidadeLivros.TabIndex = 28;
            this.lbl_quantidadeLivros.Text = "label7";
            // 
            // tb_quantidadeLivro
            // 
            this.tb_quantidadeLivro.Location = new System.Drawing.Point(199, 193);
            this.tb_quantidadeLivro.Name = "tb_quantidadeLivro";
            this.tb_quantidadeLivro.Size = new System.Drawing.Size(116, 20);
            this.tb_quantidadeLivro.TabIndex = 27;
            // 
            // cmb_generoLivro
            // 
            this.cmb_generoLivro.FormattingEnabled = true;
            this.cmb_generoLivro.Location = new System.Drawing.Point(6, 249);
            this.cmb_generoLivro.Name = "cmb_generoLivro";
            this.cmb_generoLivro.Size = new System.Drawing.Size(121, 21);
            this.cmb_generoLivro.TabIndex = 26;
            // 
            // lbl_generoLivro
            // 
            this.lbl_generoLivro.AutoSize = true;
            this.lbl_generoLivro.Location = new System.Drawing.Point(3, 233);
            this.lbl_generoLivro.Name = "lbl_generoLivro";
            this.lbl_generoLivro.Size = new System.Drawing.Size(35, 13);
            this.lbl_generoLivro.TabIndex = 25;
            this.lbl_generoLivro.Text = "label6";
            // 
            // lbl_precoLivro
            // 
            this.lbl_precoLivro.AutoSize = true;
            this.lbl_precoLivro.Location = new System.Drawing.Point(196, 233);
            this.lbl_precoLivro.Name = "lbl_precoLivro";
            this.lbl_precoLivro.Size = new System.Drawing.Size(35, 13);
            this.lbl_precoLivro.TabIndex = 24;
            this.lbl_precoLivro.Text = "label5";
            // 
            // tb_precoLivro
            // 
            this.tb_precoLivro.Location = new System.Drawing.Point(199, 249);
            this.tb_precoLivro.Name = "tb_precoLivro";
            this.tb_precoLivro.Size = new System.Drawing.Size(116, 20);
            this.tb_precoLivro.TabIndex = 23;
            // 
            // lbl_nomeEditora
            // 
            this.lbl_nomeEditora.AutoSize = true;
            this.lbl_nomeEditora.Location = new System.Drawing.Point(3, 168);
            this.lbl_nomeEditora.Name = "lbl_nomeEditora";
            this.lbl_nomeEditora.Size = new System.Drawing.Size(35, 13);
            this.lbl_nomeEditora.TabIndex = 22;
            this.lbl_nomeEditora.Text = "label4";
            // 
            // tb_nomeEditora
            // 
            this.tb_nomeEditora.Location = new System.Drawing.Point(6, 193);
            this.tb_nomeEditora.Name = "tb_nomeEditora";
            this.tb_nomeEditora.Size = new System.Drawing.Size(121, 20);
            this.tb_nomeEditora.TabIndex = 21;
            // 
            // tb_nomeAutor
            // 
            this.tb_nomeAutor.Location = new System.Drawing.Point(6, 130);
            this.tb_nomeAutor.Name = "tb_nomeAutor";
            this.tb_nomeAutor.Size = new System.Drawing.Size(309, 20);
            this.tb_nomeAutor.TabIndex = 20;
            // 
            // lbl_nomeAutor
            // 
            this.lbl_nomeAutor.AutoSize = true;
            this.lbl_nomeAutor.Location = new System.Drawing.Point(3, 114);
            this.lbl_nomeAutor.Name = "lbl_nomeAutor";
            this.lbl_nomeAutor.Size = new System.Drawing.Size(35, 13);
            this.lbl_nomeAutor.TabIndex = 19;
            this.lbl_nomeAutor.Text = "label3";
            // 
            // tb_nomeLivro
            // 
            this.tb_nomeLivro.Location = new System.Drawing.Point(6, 81);
            this.tb_nomeLivro.Name = "tb_nomeLivro";
            this.tb_nomeLivro.Size = new System.Drawing.Size(309, 20);
            this.tb_nomeLivro.TabIndex = 18;
            // 
            // lbl_nomeLivro
            // 
            this.lbl_nomeLivro.AutoSize = true;
            this.lbl_nomeLivro.Location = new System.Drawing.Point(3, 65);
            this.lbl_nomeLivro.Name = "lbl_nomeLivro";
            this.lbl_nomeLivro.Size = new System.Drawing.Size(35, 13);
            this.lbl_nomeLivro.TabIndex = 17;
            this.lbl_nomeLivro.Text = "label2";
            // 
            // tb_codigoLivro
            // 
            this.tb_codigoLivro.Location = new System.Drawing.Point(6, 34);
            this.tb_codigoLivro.Name = "tb_codigoLivro";
            this.tb_codigoLivro.Size = new System.Drawing.Size(105, 20);
            this.tb_codigoLivro.TabIndex = 16;
            // 
            // lbl_codigoLivro
            // 
            this.lbl_codigoLivro.AutoSize = true;
            this.lbl_codigoLivro.Location = new System.Drawing.Point(6, 16);
            this.lbl_codigoLivro.Name = "lbl_codigoLivro";
            this.lbl_codigoLivro.Size = new System.Drawing.Size(35, 13);
            this.lbl_codigoLivro.TabIndex = 15;
            this.lbl_codigoLivro.Text = "label1";
            // 
            // AdicionarLivros_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_formulario);
            this.Controls.Add(this.gb_grid);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AdicionarLivros_UC";
            this.Size = new System.Drawing.Size(717, 339);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_livros)).EndInit();
            this.gb_grid.ResumeLayout(false);
            this.gb_formulario.ResumeLayout(false);
            this.gb_formulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.ToolStripButton abrirToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton copiarToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridView dg_livros;
        private System.Windows.Forms.GroupBox gb_grid;
        private System.Windows.Forms.GroupBox gb_formulario;
        private System.Windows.Forms.Label lbl_quantidadeLivros;
        private System.Windows.Forms.TextBox tb_quantidadeLivro;
        private System.Windows.Forms.ComboBox cmb_generoLivro;
        private System.Windows.Forms.Label lbl_generoLivro;
        private System.Windows.Forms.Label lbl_precoLivro;
        private System.Windows.Forms.TextBox tb_precoLivro;
        private System.Windows.Forms.Label lbl_nomeEditora;
        private System.Windows.Forms.TextBox tb_nomeEditora;
        private System.Windows.Forms.TextBox tb_nomeAutor;
        private System.Windows.Forms.Label lbl_nomeAutor;
        private System.Windows.Forms.TextBox tb_nomeLivro;
        private System.Windows.Forms.Label lbl_nomeLivro;
        private System.Windows.Forms.TextBox tb_codigoLivro;
        private System.Windows.Forms.Label lbl_codigoLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn qdt;
    }
}
