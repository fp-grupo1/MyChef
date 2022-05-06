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
      

        private Form m_formPai;
        private ProdutoAlimentar produtoAEditar;
        public EditarProduto(Form formPai, ProdutoAlimentar produto)
        {
            InitializeComponent();
            m_formPai = formPai;
            produtoAEditar = produto;
        }

        private void EditarProduto_Load(object sender, EventArgs e)
        {
            // Popular Campos ao iniciar
            // Geral
            PopularCampos();

            // Produto Natural
            if (produtoAEditar is ProdutoNatural)
            {
                gbProdutoNatural.Visible = true;
                gbProdutoProcessado.Visible = false;
                gbRefeicaoPronta.Visible = false;
                PopularNatural();                
            }
                
            // Produto Processado 
            if (produtoAEditar is ProdutoProcessado)
            {
                gbProdutoNatural.Visible = false;
                gbProdutoProcessado.Visible = true;
                gbRefeicaoPronta.Visible = false;
                PopularProcessado();
            }
                                
            // Refeição Pronta
            if (produtoAEditar is RefeicaoPronta)
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
            txtCodigoID.Text = produtoAEditar.IdCod.ToString();
            txtNomeProduto.Text = produtoAEditar.Nome;
            txtPeso.Text = produtoAEditar.Peso.ToString();
            numCusto.Value = Convert.ToDecimal(produtoAEditar.Custo);
            cbAlergénios.Checked = produtoAEditar.Alergenios;

            PopularNutricionais();

            if (produtoAEditar is ProdutoNatural)
            {
                cmbTipo.SelectedIndex = 0;
            } else if (produtoAEditar is ProdutoProcessado)
            {
                cmbTipo.SelectedIndex = 1;
            } else if (produtoAEditar is RefeicaoPronta)
            {
                cmbTipo.SelectedIndex = 2;
            }
        }

        private void PopularNutricionais()
        {
            // Valores Nutricionais
            numHidratos.Value = Convert.ToDecimal(produtoAEditar.VMHidratos);
            numLipidos.Value = Convert.ToDecimal(produtoAEditar.VMLipidos);
            numProteinas.Value = Convert.ToDecimal(produtoAEditar.VMProteinas);
        }        

        private void PopularNatural()
        {
            // Produto Natural            
            txtPais.Text = ((ProdutoNatural)produtoAEditar).Origem;
            cbBiologico.Checked = ((ProdutoNatural)produtoAEditar).Biologico;
            cbSaudavel.Checked = produtoAEditar.ESaudavel();
        }

        private void PopularProcessado()
        {
            // Produto Processado           
            txtMarca.Text = ((ProdutoProcessado)produtoAEditar).Marca;
            numUnidades.Value = ((ProdutoProcessado)produtoAEditar).UnidadesEmbalagem;
            numValidade.Value = ((ProdutoProcessado)produtoAEditar).Validade;
            cbSaudavel.Checked = produtoAEditar.ESaudavel();
        }

        private void PopularRefeicaoPronta()
        {
            // Refeição Pronta
            PopularProcessado();
            txtModoPrep.Text = ((RefeicaoPronta)produtoAEditar).ModoPreparacao;
            numTempoPrep.Value = ((RefeicaoPronta)produtoAEditar).TempoPreparacao;
            cbGourmet.Checked = ((RefeicaoPronta)produtoAEditar).Gourmet;
            cbSaudavel.Checked = produtoAEditar.ESaudavel();
        }

        //-------------------------------------------------------------------
        // Alterações
        private void GuardarAlteracoes()
        {
            //Geral
            produtoAEditar.Nome = txtNomeProduto.Text;
            produtoAEditar.Peso = Convert.ToInt32(txtPeso.Text);
            produtoAEditar.Custo = Convert.ToDouble(numCusto.Value);
            produtoAEditar.Alergenios = cbAlergénios.Checked;

            produtoAEditar.VMHidratos = Convert.ToDouble(numHidratos.Value);
            produtoAEditar.VMLipidos = Convert.ToDouble(numLipidos.Value);
            produtoAEditar.VMProteinas = Convert.ToDouble(numProteinas.Value);

            if (produtoAEditar is ProdutoNatural)
            {
                GuardarNatural();
            }
            else if (produtoAEditar is ProdutoProcessado)
            {
                GuardarProcessado();
            }
            else if (produtoAEditar is RefeicaoPronta)
            {
                GuardarRefeicaoPronta();
            }
        }

        private void GuardarNatural()
        {
            // Produto Natural            
            ((ProdutoNatural)produtoAEditar).Origem = txtPais.Text;
            ((ProdutoNatural)produtoAEditar).Biologico = cbBiologico.Checked;
        }

        private void GuardarProcessado()
        {
            // Produto Processado           
            ((ProdutoProcessado)produtoAEditar).Marca = txtMarca.Text;
            ((ProdutoProcessado)produtoAEditar).UnidadesEmbalagem = Convert.ToInt32(numUnidades.Value);
            ((ProdutoProcessado)produtoAEditar).Validade = Convert.ToInt32(numValidade.Value);
        }

        private void GuardarRefeicaoPronta()
        {
            GuardarProcessado();
            ((RefeicaoPronta)produtoAEditar).ModoPreparacao = txtModoPrep.Text;
            ((RefeicaoPronta)produtoAEditar).TempoPreparacao = Convert.ToInt32(numTempoPrep.Value);
            ((RefeicaoPronta)produtoAEditar).Gourmet = cbGourmet.Checked;
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
            var resposta = MessageBox.Show("Tem a certeza que quer apagar o produto? \n\"" + produtoAEditar.IdCod + " - " + produtoAEditar.Nome, "Apagar Produto", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            
            if(resposta == DialogResult.OK)
            {
                //remover objeto do array
                m_formPai.Location = this.Location;
                this.Hide();
                m_formPai.Show();
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            produtoAEditar.Custo = Convert.ToDouble(numCusto.Value);
            txtMargem.Text = produtoAEditar.CalcMargem().ToString();
            txtPVP.Text = produtoAEditar.CalcPVP().ToString();
        }
    }
}
