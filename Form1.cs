using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjLivro.Formulario_UC;

namespace ProjLivro
{
    public partial class Forms_principal : Form
    {
        public Forms_principal()
        {
            InitializeComponent();

            this.Text = "Controle de Livros";
        }

        private void exibirFormulárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarLivros_UC addLivros = new AdicionarLivros_UC();
            TabPage pagina = new TabPage();
            pagina.Name = "addLivros";
            pagina.Text = "Adicionar Livros";
            pagina.Controls.Add(addLivros);
            tab_principal.TabPages.Add(pagina);
        }
    }
}
