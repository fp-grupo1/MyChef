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



        public Home()
        {
            InitializeComponent();
            ListaDeProdutos = new BindingList<ProdutoAlimentar>();
            dgProdutosFonte = new BindingSource();

            dgProdutosFonte.DataSource = ListaDeProdutos;
            dgProdutos.DataSource = dgProdutosFonte;
        }

        private void btnInformacaoDistribuidores_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void btnDistribuidores_Click(object sender, EventArgs e)
        {
            ProdutoAlimentar umProduto = dgProdutos.SelectedRows[0].DataBoundItem as ProdutoAlimentar;
            formDistribuidores = new Distribuidores(this, umProduto);

            formDistribuidores.Location = this.Location;
            this.Hide();
            formDistribuidores.Show();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            formNovoProduto = new NovoProduto(this,ListaDeProdutos);

            formNovoProduto.Location = this.Location;
            this.Hide();
            formNovoProduto.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ProdutoAlimentar produtoAEditar = dgProdutos.SelectedRows[0].DataBoundItem as ProdutoAlimentar;

            formEditarProduto = new EditarProduto(this,produtoAEditar);

            formEditarProduto.Location = this.Location;
            this.Hide();
            formEditarProduto.Show();
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
            var umProdutoRP = new RefeicaoPronta("RP1", "Bacalhão à Bráz", 5, "Iglo");
            ListaDeProdutos.Add(umProdutoRP);
            dgProdutos[3, 4].Value = umProdutoRP.TipoToString();
        }
        /*envia info da linha selecionada para as caixas de texto*/
        private void PreencheCampos()
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
        private void dgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PreencheCampos();

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ProdutoAlimentar umProdutoApagar = dgProdutos.SelectedRows[0].DataBoundItem as ProdutoAlimentar;
            ListaDeProdutos.Remove(umProdutoApagar);
            
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string palavraAProcurar = txtNomeProduto.Text;
            string idAProcurar = txtCodigoID.Text;


            //foreach (ProdutoAlimentar produto in ListaDeProdutos)
            //{
            //    if(produto.Nome == palavraAProcurar)
            //        dgProdutos.
            //}
            foreach (DataGridViewRow linha in dgProdutos.Rows)
            {
                if (linha.Cells[1].Value.Equals(palavraAProcurar))
                {
                    dgProdutos.ClearSelection();
                    linha.Selected = true;
                    PreencheCampos();
                    break;
                }
            }

        }

        private void btnInfoNutricinal_Click(object sender, EventArgs e)
        {

            ProdutoAlimentar produtoAMostrar = dgProdutos.SelectedRows[0].DataBoundItem as ProdutoAlimentar;
            formInfoNutricional = new InfoNutricional (this, produtoAMostrar);

            formInfoNutricional.Location = this.Location;
            this.Hide();
            formInfoNutricional.Show();
        }
    }
}
