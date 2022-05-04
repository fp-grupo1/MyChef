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
    public partial class NovoProduto : Form
    {

        private Form m_formPai;
        ProdutoAlimentar produtoAlimentar;

        public NovoProduto(Form formPai)
        {
            InitializeComponent();
            m_formPai = formPai;
        }

        private void NovoProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            m_formPai.Location = this.Location;
            this.Hide();
            m_formPai.Show();
        }

        private void btnRegistarTipo_Click(object sender, EventArgs e)
        {
            if (cbTipo.Text == "Produto Natural")
            {
                produtoAlimentar = new ProdutoNatural(txtCodigoID.Text, txtNomeProduto.Text, Convert.ToDouble(txtPeso.Text));
                RegistarInfoProduto();
                txtPais.Enabled = true;
                cbBiologico.Enabled = true;
            }
            else if (cbTipo.Text == "Produto Processado")
            {
                produtoAlimentar = new ProdutoProcessado(txtCodigoID.Text, txtNomeProduto.Text, Convert.ToDouble(txtPeso.Text), txtMarca.Text);
                RegistarInfoProduto();
                txtMarca.Enabled = true;
                numUnidades.Enabled = true;
                numValidade.Enabled = true;
            }
            else
            {
                produtoAlimentar = new RefeicaoPronta(txtCodigoID.Text, txtNomeProduto.Text, Convert.ToDouble(txtPeso.Text), txtMarca.Text);
                RegistarInfoProduto();
                txtModoPrep.Enabled = true;
                numTempoPrep.Enabled = true;
                cbGourmet.Enabled = true;
            }
            btnRegistoProduto.Enabled = true;
            btnRegistarTipo.Enabled = false;
            MessageBox.Show("A informação inicial do produto alimentar " + cbTipo.Text + " foi inserida com sucesso, finalize o resto da informação para o tipo de produto que escolheu.");
        }

        private void RegistarInfoProduto()
        {
            produtoAlimentar.Custo = Convert.ToDouble(txtCusto.Text);
            produtoAlimentar.VMProteina = Convert.ToDouble(numProteinas.Value);
            produtoAlimentar.VMLipidos = Convert.ToDouble(numLipidos.Value);
            produtoAlimentar.VMHidratos = Convert.ToDouble(numHidratos.Value);
            produtoAlimentar.Alergenios = chAlergénios.Checked;

        }

        private void btnRegistoProduto_Click(object sender, EventArgs e)
        {
            if (produtoAlimentar is ProdutoNatural)
            {
                ProdutoNatural produtoNatural = (ProdutoNatural)produtoAlimentar;
                produtoNatural.Origem = txtPais.Text;
                produtoNatural.Biologico = cbBiologico.Checked;
            }
            else if (produtoAlimentar is RefeicaoPronta) // se a condição for is ProdutoProcessado primeiro do que is RefeicaoPronta e tentar introduzir os valores
                                                         // de Refeição Pronta irá associar a classe ProdutoProcessado sendo ela derivada.
            {                
                RefeicaoPronta refeicaoPronta = (RefeicaoPronta)produtoAlimentar;
                refeicaoPronta.ModoPreparacao = txtModoPrep.Text;
                refeicaoPronta.TempoPreparacao = Convert.ToInt32(numTempoPrep.Value);
                refeicaoPronta.Gourmet = cbGourmet.Checked;

            }
            else
            {
                ProdutoProcessado produtoProcessado = (ProdutoProcessado)produtoAlimentar;
                produtoProcessado.Marca = txtMarca.Text;
                produtoProcessado.UnidadesEmbalagem = Convert.ToInt32(numUnidades.Value);
                produtoProcessado.Validade = Convert.ToInt32(numValidade.Value);
            }
            btnRegistoProduto.Enabled = false;
            btnRegistarTipo.Enabled = true;
            MessageBox.Show("Introdução de Produto Alimentar completo!");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (produtoAlimentar is RefeicaoPronta)
            {
                RefeicaoPronta refeicaoPronta = (RefeicaoPronta)produtoAlimentar;
                txtMargem.Text = Convert.ToString(refeicaoPronta.CalcMargem());
            }
            else
            {
                txtMargem.Text = Convert.ToString(produtoAlimentar.CalcMargem());
            }

            if (produtoAlimentar is ProdutoProcessado)
            {
                ProdutoProcessado produtoProcessado = (ProdutoProcessado)produtoAlimentar;
                txtPVP.Text = Convert.ToString(produtoProcessado.CalcPVP());
            }
            else
            {
                txtPVP.Text = Convert.ToString(produtoAlimentar.CalcPVP());
            }
        }
        private void ApagarInformaçãoAnteriorProduto()
        {
            txtCodigoID.Text = "";
            txtNomeProduto.Text = "";
            txtPeso.Text = "";
            txtCusto.Text = "";
            cbTipo.Text = "";
            chAlergénios.Checked = false;
            numHidratos.Value = 0;
            numLipidos.Value = 0;
            numProteinas.Value = 0;

            if (produtoAlimentar is ProdutoNatural)
            {
                txtPais.Text = "";
                txtPais.Enabled = false;
                cbBiologico.Checked = false;
                cbBiologico.Enabled = false;
            }
            else if (produtoAlimentar is RefeicaoPronta)
            {                
                txtModoPrep.Text = "";
                txtModoPrep.Enabled = false;
                numTempoPrep.Value = 0;
                numTempoPrep.Enabled = false;
                cbGourmet.Checked = false;
                cbGourmet.Enabled = false;
            }
            else
            {
                txtMarca.Text = "";
                txtMarca.Enabled = false;
                numUnidades.Value = 0;
                numUnidades.Enabled = false;
                numValidade.Value = 0;
                numValidade.Enabled = false;
            }
        }
    }
}
