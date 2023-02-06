namespace ProjLivro
{
    partial class Forms_principal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forms_principal));
            this.tab_principal = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFormulárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_principal
            // 
            this.tab_principal.Location = new System.Drawing.Point(12, 29);
            this.tab_principal.Name = "tab_principal";
            this.tab_principal.SelectedIndex = 0;
            this.tab_principal.Size = new System.Drawing.Size(717, 355);
            this.tab_principal.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarLivrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adicionarLivrosToolStripMenuItem
            // 
            this.adicionarLivrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirFormulárioToolStripMenuItem});
            this.adicionarLivrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adicionarLivrosToolStripMenuItem.Image")));
            this.adicionarLivrosToolStripMenuItem.Name = "adicionarLivrosToolStripMenuItem";
            this.adicionarLivrosToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.adicionarLivrosToolStripMenuItem.Text = "Adicionar Livros";
            // 
            // exibirFormulárioToolStripMenuItem
            // 
            this.exibirFormulárioToolStripMenuItem.Image = global::ProjLivro.Properties.Resources.Frm_HelloWorld;
            this.exibirFormulárioToolStripMenuItem.Name = "exibirFormulárioToolStripMenuItem";
            this.exibirFormulárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exibirFormulárioToolStripMenuItem.Text = "Exibir Formulário";
            this.exibirFormulárioToolStripMenuItem.Click += new System.EventHandler(this.exibirFormulárioToolStripMenuItem_Click);
            // 
            // Forms_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 396);
            this.Controls.Add(this.tab_principal);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Forms_principal";
            this.Text = "Estoque de Livros";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_principal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionarLivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirFormulárioToolStripMenuItem;
    }
}

