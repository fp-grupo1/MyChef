using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalhoGrupoClasses
{
    public partial class Home : Form
    {
        Distribuidores formDistribuidores;
        EditarProduto formEditarProduto;
        NovoProduto formNovoProduto;
        InfoNutricional formInfoNutricional;

        public BindingList<ProdutoAlimentar> ListaDeProdutos { get; private set; }
        private BindingSource dgProdutosFonte;
        private readonly int colunaId = 0;
        private readonly int colunaNome = 1;
        private readonly int colunaCusto = 2;
        private readonly int colunaTipo = 3;

        //Construtor do Formulário Home
        public Home()
        {
            InitializeComponent();
            ListaDeProdutos = new BindingList<ProdutoAlimentar>();
            dgProdutosFonte = new BindingSource();
            
            dgProdutosFonte.DataSource = ListaDeProdutos;
            dgProdutos.DataSource = dgProdutosFonte;
        }


        //Carregar dados para a classe utilizar
        private void Home_Load(object sender, EventArgs e)
        {
            //PopulateList();
            dgProdutos.SelectedRows[0].Selected = false;           
        }
        
        //Abre formulário para mostrar e gerir informação sobre os distribuidores do produto selecionado
        private void btnDistribuidores_Click(object sender, EventArgs e)
        {
            if (dgProdutos.SelectedRows.Count != 0)
            {
                ProdutoAlimentar umProduto = dgProdutos.SelectedRows[0].DataBoundItem as ProdutoAlimentar;
                formDistribuidores = new Distribuidores(this, umProduto);
                formDistribuidores.Location = this.Location;
                this.Hide();
                formDistribuidores.Show();
            }
            else
            {
                MensagemProdutoNaoSelecionado();
            }
        }
        
        //Abre formulário para Criar novo Produto
        private void btnNovo_Click(object sender, EventArgs e)
        {
            formNovoProduto = new NovoProduto(this, ListaDeProdutos);

            formNovoProduto.Location = this.Location;
            this.Hide();
            formNovoProduto.Show();
        }      
        
        //Abre formulário para editar o produto selecionado
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgProdutos.SelectedRows.Count != 0)
            {
                ProdutoAlimentar produtoAEditar = dgProdutos.SelectedRows[0].DataBoundItem as ProdutoAlimentar;
                formEditarProduto = new EditarProduto(this, produtoAEditar);
                formEditarProduto.Location = this.Location;
                this.Hide();
                formEditarProduto.Show();
            }
            else
            {
                MensagemProdutoNaoSelecionado();
            }   
        }                     
        
        //Seleciona Produto da tabela  
        private void dgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PreencheCampos();
        }
        
        //Apaga Produto
        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgProdutos.SelectedRows.Count != 0)
            {
                ProdutoAlimentar umProdutoApagar = dgProdutos.SelectedRows[0].DataBoundItem as ProdutoAlimentar;
                DialogResult resposta = MessageBox.Show(
                    "Tem a certeza que pertende apagar o produto " + umProdutoApagar.Nome + "?",
                    "Alteração do Produto",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (resposta == DialogResult.OK)
                {
                    ListaDeProdutos.Remove(umProdutoApagar);
                    PreencheCampos();
                    MessageBox.Show(
                        "Produto apagado com Sucesso",
                        "Confirmação de ação apagar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MensagemProdutoNaoSelecionado();
            }
        }
        
        //Procura Produto por nome
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string palavraAProcurar = txtNomeProduto.Text;
            string idAProcurar = txtCodigoID.Text;

            if (palavraAProcurar == "")
            {
                foreach (DataGridViewRow linha in dgProdutos.Rows)
                {
                    linha.Visible = true;
                }
            }
            else
            {
                try
                {
                    foreach (DataGridViewRow linha in dgProdutos.Rows)
                    {
                        if (linha.Cells[colunaNome].Value.Equals(palavraAProcurar))
                        {
                            dgProdutos.ClearSelection();
                            linha.Selected = true;
                            PreencheCampos();
                            dgProdutos.CurrentCell = linha.Cells[colunaNome];                           
                        }                       
                    }
                    foreach (DataGridViewRow linha in dgProdutos.Rows)
                    {
                        if (!linha.Cells[colunaNome].Value.Equals(palavraAProcurar))
                        {
                            linha.Visible = false;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("erro");

                }
            }
        }
        
        //Abre formulário para mostrar informação nutricional do produto selecionado
        private void btnInfoNutricinal_Click(object sender, EventArgs e)
        {
            if (dgProdutos.SelectedRows.Count != 0)
            {
                ProdutoAlimentar produtoAMostrar = dgProdutos.SelectedRows[0].DataBoundItem as ProdutoAlimentar;
                formInfoNutricional = new InfoNutricional(this, produtoAMostrar);

                formInfoNutricional.Location = this.Location;
                this.Hide();
                formInfoNutricional.Show();
            }
            else
            {
                MensagemProdutoNaoSelecionado();
            }
        }
        //Mensagem que surge sempre que um produto não está selecionado
        private void MensagemProdutoNaoSelecionado()
        {
            DialogResult resposta = MessageBox.Show(
            "Não existe produto selecionado, por favor selecione um produto",
            "Sem valores selecionado",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning);
        }
        /*Metodo temporario para popular a dataGridView com alguns produtos para testar fucionalidades*/
        private void PopulateList()
        {
            var umProdutoNat = new ProdutoNatural("PN1", "Batatas", 5);
            ListaDeProdutos.Add(umProdutoNat);
            dgProdutos[3, 0].Value = umProdutoNat.TipoToString();
            ListaDeProdutos.Add(new ProdutoNatural("PN2", "Nabos", 5));
            dgProdutos[3, 1].Value = umProdutoNat.TipoToString();
            var umProdutoPP = new ProdutoProcessado("PP1", "Batatas Fritas", 5, "Lays");
            ListaDeProdutos.Add(umProdutoPP);
            dgProdutos[3, 2].Value = umProdutoPP.TipoToString();
            umProdutoPP = new ProdutoProcessado("PP2", "Batatas Fritas Picantes", 5, "Lays");
            ListaDeProdutos.Add(umProdutoPP);
            dgProdutos[3, 3].Value = umProdutoPP.TipoToString();
            var umProdutoRP = new RefeicaoPronta("RP1", "Bacalhau à Bráz", 5, "Iglo");
            ListaDeProdutos.Add(umProdutoRP);
            dgProdutos[3, 4].Value = umProdutoRP.TipoToString();
            umProdutoRP = new RefeicaoPronta("RP2", "Bacalhau à Zé do pipo", 5, "Iglo");
            ListaDeProdutos.Add(umProdutoRP);
            dgProdutos[3, 5].Value = umProdutoRP.TipoToString();
            ListaDeProdutos.Add(new ProdutoNatural("PN2", "Nabos", 5));
            dgProdutos[3, 1].Value = umProdutoNat.TipoToString();
            ListaDeProdutos.Add(new ProdutoNatural("PN2", "Nabos", 5));
            dgProdutos[3, 1].Value = umProdutoNat.TipoToString();
            ListaDeProdutos.Add(new ProdutoNatural("PN2", "courgette", 5));
            dgProdutos[3, 1].Value = umProdutoNat.TipoToString();
            ListaDeProdutos.Add(new ProdutoNatural("PN2", "rabanos", 5));
            dgProdutos[3, 1].Value = umProdutoNat.TipoToString();
            ListaDeProdutos.Add(new ProdutoNatural("PN2", "couves", 5));
            dgProdutos[3, 1].Value = umProdutoNat.TipoToString();
            //PreencherTipo();
        }       
        /*Metodo que popula as caixas de texto com informação da linha selecionada*/
        private void PreencheCampos()
        {
            if (dgProdutos.SelectedRows[0].Selected)
            {
                ProdutoAlimentar esteProduto = dgProdutos.SelectedRows[0].DataBoundItem as ProdutoAlimentar;
                txtNomeProduto.Text = esteProduto.Nome;
                txtCodigoID.Text = esteProduto.IdCod;
                switch (esteProduto.TipoToString())
                {
                    case "Produto Natural":
                        cbProdNaturais.Checked = true;
                        cbProdProcessados.Checked = false;
                        cbRefPronta.Checked = false;
                        break;
                    case "Produto Processado":
                        cbProdNaturais.Checked = false;
                        cbProdProcessados.Checked = true;
                        cbRefPronta.Checked = false;
                        break;
                    case "Refeição Pronta":
                        cbProdNaturais.Checked = false;
                        cbProdProcessados.Checked = false;
                        cbRefPronta.Checked = true;
                        break;
                    default:
                        break;
                }
            }
        }
        private void PreencherTipo()
        {
            if (dgProdutos.SelectedRows[0].Selected)
            {
                foreach (DataGridViewRow linha in dgProdutos.Rows)
                {
                    if (linha.Cells[colunaTipo].Value == null)
                    {
                        ProdutoAlimentar umProdutoTipificar = dgProdutos.SelectedRows[0].DataBoundItem as ProdutoAlimentar;
                        linha.Cells[3].Value = umProdutoTipificar.TipoToString();
                    }
                }
            }
        }
        private void LimparEscolha()
        {
            if (dgProdutos.SelectedRows.Count != 0)
            {
                dgProdutos.SelectedRows[0].Selected = false;
            }
            txtNomeProduto.Text = "";
            txtCodigoID.Text = "";
            cbProdNaturais.Checked = false;
            cbProdProcessados.Checked = false;
            cbRefPronta.Checked = false;
        }

        private void dgProdutos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {            
            dgProdutos.Rows[ListaDeProdutos.Count - 1].Cells[colunaTipo].Value = ListaDeProdutos.Last().TipoToString();            
        }

        private void btnPesquisaId_Click(object sender, EventArgs e)
        {
            string IdAProcurar = txtCodigoID.Text;
            foreach (DataGridViewRow linha in dgProdutos.Rows)
            {
                if (linha.Cells[colunaId].Value.Equals(IdAProcurar))
                {
                    dgProdutos.ClearSelection();
                    linha.Selected = true;
                    dgProdutos.FirstDisplayedScrollingRowIndex = linha.Index;
                    PreencheCampos();
                    dgProdutos.CurrentCell = linha.Cells[colunaId];
                }
            }
        }

        private void btnLimparEscolha_Click(object sender, EventArgs e)
        {
            LimparEscolha();
        }
    }
}
