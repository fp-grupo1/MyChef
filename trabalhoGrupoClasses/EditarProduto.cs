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
    public partial class EditarProduto : Form
    {
        ProdutoAlimentar produto;

        private Form m_formPai;

        public EditarProduto(Form formPai)
        {
            InitializeComponent();
            m_formPai = formPai;
        }

        public void PRODUTOTESTE()
        {
            //produto = new ProdutoNatural("pn123", "Teste", 300);
            //produto = new ProdutoProcessado("pn123", "Teste", 300, "Teste");
            produto = new RefeicaoPronta("pn123", "Teste", 300, "Teste");
        }

        private void EditarProduto_Load(object sender, EventArgs e)
        {
            PRODUTOTESTE();
            // Popular Campos ao iniciar
            // Geral
            PopularCampos();

            // Produto Natural
            if (produto is ProdutoNatural)
            {
                gbProdutoNatural.Visible = true;
                gbProdutoProcessado.Visible = false;
                gbRefeicaoPronta.Visible = false;
                PopularNatural();                
            }
                
            // Produto Processado 
            if (produto is ProdutoProcessado)
            {
                gbProdutoNatural.Visible = false;
                gbProdutoProcessado.Visible = true;
                gbRefeicaoPronta.Visible = false;
                PopularProcessado();
            }
                                
            // Refeição Pronta
            if (produto is RefeicaoPronta)
            {
                gbProdutoNatural.Visible = false;
                gbProdutoProcessado.Visible = true;
                gbRefeicaoPronta.Visible = true;
                PopularRefeicaoPronta();
            }                
        }

        //-------------------------------------------------------------------
        // Popular campos ao inicializar
        private void PopularCampos()
        {
            //Geral
            txtCodigoID.Text = produto.IdCod.ToString();
            txtNomeProduto.Text = produto.Nome;
            txtPeso.Text = produto.Peso.ToString();
            txtCusto.Text = produto.Custo.ToString();
            cbAlergénios.Checked = produto.Alergenios;

            PopularNutricionais();

            if (produto is ProdutoNatural)
            {
                cmbTipo.SelectedIndex = 0;
            } else if (produto is ProdutoProcessado)
            {
                cmbTipo.SelectedIndex = 1;
            } else if (produto is RefeicaoPronta)
            {
                cmbTipo.SelectedIndex = 2;
            }
        }

        private void PopularNutricionais()
        {
            // Valores Nutricionais
            numHidratos.Value = Convert.ToDecimal(produto.VMHidratos);
            numLipidos.Value = Convert.ToDecimal(produto.VMLipidos);
            numProteinas.Value = Convert.ToDecimal(produto.VMProteinas);
        }        

        private void PopularNatural()
        {
            // Produto Natural            
            txtPais.Text = ((ProdutoNatural)produto).Origem;
            cbBiologico.Checked = ((ProdutoNatural)produto).Biologico;
            cbSaudavel.Checked = produto.ESaudavel();
        }

        private void PopularProcessado()
        {
            // Produto Processado           
            txtMarca.Text = ((ProdutoProcessado)produto).Marca;
            numUnidades.Value = ((ProdutoProcessado)produto).UnidadesEmbalagem;
            numValidade.Value = ((ProdutoProcessado)produto).Validade;
            cbSaudavel.Checked = produto.ESaudavel();
        }

        private void PopularRefeicaoPronta()
        {
            // Refeição Pronta
            PopularProcessado();
            txtModoPrep.Text = ((RefeicaoPronta)produto).ModoPreparacao;
            numTempoPrep.Value = ((RefeicaoPronta)produto).TempoPreparacao;
            cbGourmet.Checked = ((RefeicaoPronta)produto).Gourmet;
            cbSaudavel.Checked = produto.ESaudavel();
        }

        //-------------------------------------------------------------------
        // Alterações
        private void GuardarAlteracoes()
        {
            //Geral
            produto.Nome = txtNomeProduto.Text;
            produto.Peso = Convert.ToInt32(txtPeso.Text);
            produto.Custo = Convert.ToDouble(txtCusto.Text);
            produto.Alergenios = cbAlergénios.Checked;

            produto.VMHidratos = Convert.ToDouble(numHidratos.Value);
            produto.VMLipidos = Convert.ToDouble(numLipidos.Value);
            produto.VMProteinas = Convert.ToDouble(numProteinas.Value);

            if (produto is ProdutoNatural)
            {
                GuardarNatural();
            }
            else if (produto is ProdutoProcessado)
            {
                GuardarProcessado();
            }
            else if (produto is RefeicaoPronta)
            {
                GuardarRefeicaoPronta();
            }
        }

        private void GuardarNatural()
        {
            // Produto Natural            
            ((ProdutoNatural)produto).Origem = txtPais.Text;
            ((ProdutoNatural)produto).Biologico = cbBiologico.Checked;
        }

        private void GuardarProcessado()
        {
            // Produto Processado           
            ((ProdutoProcessado)produto).Marca = txtMarca.Text;
            ((ProdutoProcessado)produto).UnidadesEmbalagem = Convert.ToInt32(numUnidades.Value);
            ((ProdutoProcessado)produto).Validade = Convert.ToInt32(numValidade.Value);
        }

        private void GuardarRefeicaoPronta()
        {
            GuardarProcessado();
            ((RefeicaoPronta)produto).ModoPreparacao = txtModoPrep.Text;
            ((RefeicaoPronta)produto).TempoPreparacao = Convert.ToInt32(numTempoPrep.Value);
            ((RefeicaoPronta)produto).Gourmet = cbGourmet.Checked;
        }


        private void btnAnterior_Click(object sender, EventArgs e)
        {
            m_formPai.Location = this.Location;
            this.Hide();
            m_formPai.Show();
        }

        private void btnGuardarAlteracoes_Click(object sender, EventArgs e)
        {
            GuardarAlteracoes();

            MessageBox.Show("As alterações foram guardadas.", "Alteração do Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            m_formPai.Location = this.Location;
            this.Hide();
            m_formPai.Show();
        }

        private void btnApagarProduto_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Tem a certeza que quer apagar o produto? \n\"" + produto.IdCod + " - " + produto.Nome, "Apagar Produto", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            
            if(resposta == DialogResult.OK)
            {
                //remover objeto do array
                m_formPai.Location = this.Location;
                this.Hide();
                m_formPai.Show();
            }

        }
    }
}
