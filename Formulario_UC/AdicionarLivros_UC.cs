using BibliotecaDeUtilidades;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjLivro.Formulario_UC
{
    public partial class AdicionarLivros_UC : UserControl
    {
        public AdicionarLivros_UC()
        {
            InitializeComponent();
            lbl_codigoLivro.Text = "Código do Livros";
            lbl_nomeLivro.Text = "Nome do Livro";
            lbl_nomeAutor.Text = "Nome do Autor";
            lbl_nomeEditora.Text = "Nome da Editora";
            lbl_generoLivro.Text = "Genêro";
            lbl_precoLivro.Text = "Preço do Livro";
            lbl_quantidadeLivros.Text = "Quantidade de Livros";

            cmb_generoLivro.Items.Add("Drama");
            cmb_generoLivro.Items.Add("Ação");
            cmb_generoLivro.Items.Add("Aventura");
            cmb_generoLivro.Items.Add("Suspense");
            cmb_generoLivro.Items.Add("Terror");
            cmb_generoLivro.Items.Add("Comédia");
            cmb_generoLivro.Items.Add("Romance");

            toolStrip1.Items[0].Text = "Salvar Livro";
            toolStrip1.Items[1].Text = "Carregar Livro";
            toolStrip1.Items[3].Text = "Salvar Alteração";
            toolStrip1.Items[4].Text = "Excluir Item";
            toolStrip1.Items[5].Text = "Limpar Formulário";

            gb_formulario.Text = "Dados do Livro";
            gb_grid.Text = "Lista de Livros";
            MostrarLivrosGrid();
        }
        //Botão de adicionar o livro
        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Instancia da Classe livros
                Livros.Unit livros = new Livros.Unit();
                //Método de adicionar o livro
                livros = AddLivroFormulario();
                //Função da Classe Livros.Unit
                livros.ValidaClasse();
                //Apos toda a validação vamos adicionar o livro com o metodo de incluir.
                livros.IncluirFicharioSqlServer(tb_codigoLivro.Text);
                MessageBox.Show("Livro adicionado com sucesso!", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LimparFormulario();
                MostrarLivrosGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        //Método de alterar dados.
        private void copiarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Livros.Unit livros = new Livros.Unit();
                livros = AddLivroFormulario();
                livros.ValidaClasse();
                livros.AlterarFichario(Convert.ToInt32(tb_codigoLivro.Text));
                MessageBox.Show("Dados alterado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarLivrosGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Método de abrir dados.
        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_codigoLivro.Text == "")
                {
                    MessageBox.Show("Identificador do cliente vazio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Livros.Unit livros = new Livros.Unit();
                    livros = livros.BuscarFichario(tb_codigoLivro.Text);
                    if (livros == null)
                    {
                        MessageBox.Show("Identificador não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreverFormulario(livros);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Método de excluir arquivos.
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_codigoLivro.Text == "")
                {
                    MessageBox.Show("Identificador do cliente vazio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Livros.Unit livros = new Livros.Unit();
                    //a variável livros vai receber os dados do livro.
                    livros = livros.BuscarFichario(tb_codigoLivro.Text);
                    //Se a variável for vazia.
                    if (livros == null)
                    {
                        MessageBox.Show("Dados não encontrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreverFormulario(livros);
                        if (DialogResult.OK == MessageBox.Show("Deseja realmente excluir os dados mostrado", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                        {
                            livros.ExcluirFicharioSql(tb_codigoLivro.Text);
                            MessageBox.Show("Conteúdo excluido com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparFormulario();
                            MostrarLivrosGrid();
                        }
                        else
                        {
                            MessageBox.Show("Operação cancelada com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Limpar formulário.
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        //Método de Limpar o Formulário.
        public void LimparFormulario()
        {
            tb_codigoLivro.Text = "";
            tb_nomeAutor.Text = "";
            tb_nomeEditora.Text = "";
            tb_nomeLivro.Text = "";
            tb_precoLivro.Text = "";
            tb_quantidadeLivro.Text = "";
            cmb_generoLivro.SelectedIndex = -1;
        }

        public void EscreverFormulario(Livros.Unit livros)
        {
            tb_codigoLivro.Text = livros.Id.ToString();
            tb_nomeLivro.Text = livros.nomeLivro;
            tb_nomeAutor.Text = livros.nomeAutor;
            tb_nomeEditora.Text = livros.editora;
            tb_quantidadeLivro.Text = livros.qdt.ToString();
            tb_precoLivro.Text = livros.valor.ToString();
            for (int i = 0; i <= cmb_generoLivro.Items.Count - 1; i++)
            {
                if (livros.categoria == cmb_generoLivro.Items[i].ToString())
                {
                    cmb_generoLivro.SelectedIndex = i;
                }
            }
        }

        public Livros.Unit AddLivroFormulario()
        {
            Livros.Unit livros = new Livros.Unit();

            if (Information.IsNumeric(tb_codigoLivro.Text))
            {
                int numero = Convert.ToInt32(tb_codigoLivro.Text);
                if (numero < 0)
                {
                    livros.Id = 0;
                }
                else
                {
                    livros.Id = numero;
                }
            }
            livros.nomeLivro = tb_nomeLivro.Text;
            livros.nomeAutor = tb_nomeAutor.Text;
            livros.editora = tb_nomeEditora.Text;

            if (cmb_generoLivro.SelectedIndex < 0)
            {
                livros.categoria = "";
            }
            else
            {
                livros.categoria = cmb_generoLivro.Items[cmb_generoLivro.SelectedIndex].ToString();
            }

            if (Information.IsNumeric(tb_quantidadeLivro.Text))
            {
                var numero = Convert.ToInt32(tb_quantidadeLivro.Text);
                if (numero < 0)
                {
                    livros.qdt = 0;
                }
                else
                {
                    livros.qdt = numero;
                }
            }

            if (Information.IsNumeric(tb_precoLivro.Text))
            {
                Double preco = Convert.ToDouble(tb_precoLivro.Text);
                if (preco < 0)
                {
                    livros.valor = 0;
                }
                else
                {
                    livros.valor = preco;
                }
            }
            return livros;
        }
        //Método que vai adicionar os dados no DataGrid, porém sera chamado quando tivermos que fazer alguma atualização no sistema ex:. adicionar um novo livro, exluir e alterar.
        private void MostrarLivrosGrid()
        {
            try
            {
                Livros.Unit livros = new Livros.Unit();
                var ListaBusca = livros.BuscaFicahrioTodos();
                //Sempre que eu for atualizar o DataGrid tenho que adicionar novas linhas.
                dg_livros.Rows.Clear();
                for (int i = 0; i <= ListaBusca.Count - 1; i++)
                {
                    //Para popular meu DataGrid, vou criar um DataDridViewRow (são basicamente linhas de uma tabela).
                    DataGridViewRow row = new DataGridViewRow();
                    //Além de criar linhas tenho que criar as celulas. Obs:. dg_livros é o DataGrid que adicionei no Design.
                    row.CreateCells(dg_livros);
                    //Estou preenchendo as colunas das celulas do DataGrid do Design.
                    //Agora estou adicionando na coluna 0 do row, o valor do ListaBusca na linha i da coluna 0.
                    row.Cells[0].Value = ListaBusca[i][0].ToString();
                    row.Cells[1].Value = ListaBusca[i][1].ToString();
                    row.Cells[2].Value = ListaBusca[i][2].ToString();
                    //Adicionando a linha no meu DataGrid.
                    dg_livros.Rows.Add(row);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
