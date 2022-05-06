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
        private ProdutoAlimentar umProdutoAlimentar;
        private BindingList<ProdutoAlimentar> listaDeProdutos;

        public NovoProduto(Form formPai, BindingList<ProdutoAlimentar> lista)
        {
            InitializeComponent();
            m_formPai = formPai;
            listaDeProdutos = lista;
        }

        private void NovoProduto_Load(object sender, EventArgs e)
        {
            gbProdutoNatural.Hide();
            gbProdutoProcessado.Hide();
            gbRefeicaoPronta.Hide();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            m_formPai.Location = this.Location;
            this.Hide();
            m_formPai.Show();

        }


        private void btnRegistarTipo_Click(object sender, EventArgs e)
        {
            string tipoDeProduto = cbTipo.Text;
            switch (tipoDeProduto)
            {
                case "Produto Natural":
                    umProdutoAlimentar = new ProdutoNatural(txtCodigoID.Text, txtNomeProduto.Text, Convert.ToDouble(txtPeso.Text));
                    (umProdutoAlimentar as ProdutoNatural).Origem = txtPais.Text;
                    (umProdutoAlimentar as ProdutoNatural).Biologico = cbBiologico.Checked;
                    break;
                case "Produto Processado":
                    umProdutoAlimentar = new ProdutoProcessado(txtCodigoID.Text, txtNomeProduto.Text, Convert.ToDouble(txtPeso.Text), txtMarca.Text);
                    (umProdutoAlimentar as ProdutoProcessado).Marca = txtMarca.Text;
                    (umProdutoAlimentar as ProdutoProcessado).UnidadesEmbalagem = Convert.ToInt32(numUnidades.Value);
                    (umProdutoAlimentar as ProdutoProcessado).Validade = Convert.ToInt32(numValidade.Value);
                    break;
                case "Refeição Pronta":
                    umProdutoAlimentar = new RefeicaoPronta(txtCodigoID.Text, txtNomeProduto.Text, Convert.ToDouble(txtPeso.Text), txtMarca.Text);
                    (umProdutoAlimentar as RefeicaoPronta).Marca = txtMarca.Text;
                    (umProdutoAlimentar as RefeicaoPronta).UnidadesEmbalagem = Convert.ToInt32(numUnidades.Value);
                    (umProdutoAlimentar as RefeicaoPronta).Validade = Convert.ToInt32(numValidade.Value);
                    (umProdutoAlimentar as RefeicaoPronta).ModoPreparacao = txtModoPrep.Text;
                    (umProdutoAlimentar as RefeicaoPronta).TempoPreparacao = Convert.ToInt32(numTempoPrep.Value);
                    (umProdutoAlimentar as RefeicaoPronta).Gourmet = cbGourmet.Checked;
                    break;
                default:
                    gbProdutoNatural.Hide();
                    gbProdutoProcessado.Hide();
                    gbRefeicaoPronta.Hide();
                    ApagarInformaçãoAnteriorProduto();
                    MessageBox.Show(
                        "Tipo de Produto Alimentar, " + cbTipo.Text + ", não existe.",
                        "Tipo Inválido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    break;
            }
        }
        

        private void RegistarInfoProduto()
        {
            umProdutoAlimentar.Custo = Convert.ToDouble(txtCusto.Text);
            umProdutoAlimentar.VMProteinas = Convert.ToDouble(numProteinas.Value);
            umProdutoAlimentar.VMLipidos = Convert.ToDouble(numLipidos.Value);
            umProdutoAlimentar.VMHidratos = Convert.ToDouble(numHidratos.Value);
            umProdutoAlimentar.Alergenios = chAlergénios.Checked;
        }

        private void btnRegistoProduto_Click(object sender, EventArgs e)
        {
            if (umProdutoAlimentar is ProdutoNatural)
            {
                ProdutoNatural produtoNatural = (ProdutoNatural)umProdutoAlimentar;
                produtoNatural.Origem = txtPais.Text;
                produtoNatural.Biologico = cbBiologico.Checked;
            }
            else if (umProdutoAlimentar is RefeicaoPronta) // se a condição for is ProdutoProcessado primeiro do que is RefeicaoPronta e tentar introduzir os valores
                                                           // de Refeição Pronta irá associar a classe ProdutoProcessado sendo ela derivada.
            {
                RefeicaoPronta refeicaoPronta = (RefeicaoPronta)umProdutoAlimentar;
                refeicaoPronta.ModoPreparacao = txtModoPrep.Text;
                refeicaoPronta.TempoPreparacao = Convert.ToInt32(numTempoPrep.Value);
                refeicaoPronta.Gourmet = cbGourmet.Checked;
            }
            else
            {
                ProdutoProcessado produtoProcessado = (ProdutoProcessado)umProdutoAlimentar;
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
            txtMargem.Text = umProdutoAlimentar.CalcMargem().ToString();
            txtPVP.Text = umProdutoAlimentar.CalcPVP().ToString();
        }
        private void btnCriarNovo_Click(object sender, EventArgs e)
        {
            ApagarInformaçãoAnteriorProduto();
            gbProdutoNatural.Hide();
            gbProdutoProcessado.Hide();
            gbRefeicaoPronta.Hide();
            umProdutoAlimentar=null;
        }

        private void ApagarInformaçãoAnteriorProduto()
        {
            //Produto ALimentar
            txtCodigoID.Text = "";
            txtNomeProduto.Text = "";
            txtPeso.Text = "";
            txtCusto.Text = "";
            cbTipo.Text = "";
            chAlergénios.Checked = false;
            numHidratos.Value = 0;
            numLipidos.Value = 0;
            numProteinas.Value = 0;
            //Produtos Biologicos
            txtPais.Text = "";
            txtPais.Enabled = false;
            cbBiologico.Checked = false;
            cbBiologico.Enabled = false;
            //Refeição Pronta
            txtModoPrep.Text = "";
            txtModoPrep.Enabled = false;
            numTempoPrep.Value = 0;
            numTempoPrep.Enabled = false;
            cbGourmet.Checked = false;
            cbGourmet.Enabled = false;
            //Produto Processado
            txtMarca.Text = "";
            txtMarca.Enabled = false;
            numUnidades.Value = 0;
            numUnidades.Enabled = false;
            numValidade.Value = 0;
            numValidade.Enabled = false;
        }
        private void MensagemTipoDesconhecido()
        {
            gbProdutoNatural.Hide();
            gbProdutoProcessado.Hide();
            gbRefeicaoPronta.Hide();
            ApagarInformaçãoAnteriorProduto();
            MessageBox.Show(
                "Tipo de Produto Alimentar, " + cbTipo.Text + ", não existe.",
                "Tipo Inválido",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoDeProduto = cbTipo.Text;
            switch (tipoDeProduto)
            {
                case "Produto Natural":
                    gbRefeicaoPronta.Hide();
                    gbProdutoProcessado.Hide();
                    gbProdutoNatural.Show();
                    break;
                case "Produto Processado":
                    gbRefeicaoPronta.Hide();
                    gbProdutoProcessado.Show();
                    gbProdutoNatural.Hide();
                    break;
                case "Refeição Pronta":
                    gbRefeicaoPronta.Show();
                    gbProdutoProcessado.Show();
                    gbProdutoNatural.Hide();
                    break;
                default:
                    MensagemTipoDesconhecido();
                    break;
            }
        }
    }
}


