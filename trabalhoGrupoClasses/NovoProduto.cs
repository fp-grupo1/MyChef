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
            ApagarInformaçãoAnteriorProduto();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            m_formPai.Location = this.Location;
            this.Hide();
            m_formPai.Show();

        }

        private bool CamposGeraisPreenchidos()
        {
            if (txtCodigoID.Text != "" && txtNomeProduto.Text != "" && numPeso.Value != 0 && numCusto.Value != 0 && txtPrefixoCodigo.Text != "")
                return true;
            else
            {
                MessageBox.Show("Existem campos por preencher. Preencha os campos para registar um novo produto.", "Campos Gerais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private bool MarcaPreenchida()
        {
            if (txtMarca.Text != "")
                return true;
            else
            {                
                return false;
            }
        }

        private bool NutricionalTotalCheck()
        {
            double proteina = Convert.ToDouble(numProteinas.Value);
            double lipidos = Convert.ToDouble(numLipidos.Value);
            double hidratos = Convert.ToDouble(numHidratos.Value);

            if (proteina + lipidos + hidratos > 100)
            {
                MessageBox.Show("Valores Nutricionais por 100g excedem 100g", "Valores Nutricionais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
                
            else return true;
        }

        private void RegistarInfoProduto()
        {
            umProdutoAlimentar.Custo = Convert.ToDouble(numCusto.Value);
            umProdutoAlimentar.Alergenios = chAlergénios.Checked;

            umProdutoAlimentar.VMProteinas = Convert.ToDouble(numProteinas.Value);
            umProdutoAlimentar.VMLipidos = Convert.ToDouble(numLipidos.Value);
            umProdutoAlimentar.VMHidratos = Convert.ToDouble(numHidratos.Value);           
        }

        private void btnRegistoProduto_Click(object sender, EventArgs e)
        {
            string tipoDeProduto = cbTipo.Text;

            if (NutricionalTotalCheck() && CamposGeraisPreenchidos())
            {

                //Registar dados especificos à categoria do produto
                switch (tipoDeProduto)
                {
                    case "Produto Natural":                        
                        {
                            
                            umProdutoAlimentar = new ProdutoNatural(txtPrefixoCodigo.Text + txtCodigoID.Text, txtNomeProduto.Text, Convert.ToDouble(numPeso.Value));
                            RegistarInfoProduto();
                            (umProdutoAlimentar as ProdutoNatural).Origem = txtPais.Text;
                            (umProdutoAlimentar as ProdutoNatural).Biologico = cbBiologico.Checked;
                            listaDeProdutos.Add(umProdutoAlimentar);
                        }                        
                        break;
                    case "Produto Processado":
                        if (MarcaPreenchida())
                        {                        
                            umProdutoAlimentar = new ProdutoProcessado(txtCodigoID.Text, txtNomeProduto.Text, Convert.ToDouble(numPeso.Value), txtMarca.Text);
                            RegistarInfoProduto();
                            (umProdutoAlimentar as ProdutoProcessado).Marca = txtMarca.Text;
                            (umProdutoAlimentar as ProdutoProcessado).UnidadesEmbalagem = Convert.ToInt32(numUnidades.Value);
                            (umProdutoAlimentar as ProdutoProcessado).Validade = Convert.ToInt32(numValidade.Value);
                            listaDeProdutos.Add(umProdutoAlimentar);
                        } else MessageBox.Show("A marca do produto tem que ser preenchida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;                    
                        
                    case "Refeição Pronta":
                        if (MarcaPreenchida())
                        {                            
                            umProdutoAlimentar = new RefeicaoPronta(txtCodigoID.Text, txtNomeProduto.Text, Convert.ToDouble(numPeso.Value), txtMarca.Text);
                            RegistarInfoProduto();
                            (umProdutoAlimentar as RefeicaoPronta).Marca = txtMarca.Text;
                            (umProdutoAlimentar as RefeicaoPronta).UnidadesEmbalagem = Convert.ToInt32(numUnidades.Value);
                            (umProdutoAlimentar as RefeicaoPronta).Validade = Convert.ToInt32(numValidade.Value);
                            (umProdutoAlimentar as RefeicaoPronta).ModoPreparacao = txtModoPrep.Text;
                            (umProdutoAlimentar as RefeicaoPronta).TempoPreparacao = Convert.ToInt32(numTempoPrep.Value);
                            (umProdutoAlimentar as RefeicaoPronta).Gourmet = cbGourmet.Checked;
                            listaDeProdutos.Add(umProdutoAlimentar);
                        }
                        else MessageBox.Show("A marca do produto tem que ser preenchida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        gbProdutoNatural.Hide();
                        gbProdutoProcessado.Hide();
                        gbRefeicaoPronta.Hide();
                        ApagarInformaçãoAnteriorProduto();
                        MessageBox.Show(
                            "Tipo de Produto não existe.",
                            "Tipo Inválido",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        break;
                }             
                //lista de produtos .add
                
            }            
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
            //Produto Alimentar
            txtPrefixoCodigo.Text = "";
            txtCodigoID.Text = "";
            txtNomeProduto.Text = "";
            numPeso.Value = 0;
            numCusto.Value = 0;
            cbTipo.Text = "";
            chAlergénios.Checked = true;
            numHidratos.Value = 0;
            numLipidos.Value = 0;
            numProteinas.Value = 0;
            //Produtos Biologicos
            txtPais.Text = "Portugal";
            //txtPais.Enabled = false;
            cbBiologico.Checked = true;
            //cbBiologico.Enabled = false;
            //Refeição Pronta
            txtModoPrep.Text = "";
            //txtModoPrep.Enabled = false;
            numTempoPrep.Value = 0;
            //numTempoPrep.Enabled = false;
            cbGourmet.Checked = false;
            //cbGourmet.Enabled = false;
            //Produto Processado
            txtMarca.Text = "";
            //txtMarca.Enabled = false;
            numUnidades.Value = 0;
            //numUnidades.Enabled = false;
            numValidade.Value = 0;
            //numValidade.Enabled = false;
        }
        private void MensagemTipoDesconhecido()
        {
            gbProdutoNatural.Hide();
            gbProdutoProcessado.Hide();
            gbRefeicaoPronta.Hide();
            ApagarInformaçãoAnteriorProduto();
            MessageBox.Show(
                "Tipo de Produto não existe.",
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
                    txtPrefixoCodigo.Text = "PN";
                    gbRefeicaoPronta.Hide();
                    gbProdutoProcessado.Hide();
                    gbProdutoNatural.Show();
                    break;
                case "Produto Processado":
                    txtPrefixoCodigo.Text = "PP";
                    gbRefeicaoPronta.Hide();
                    gbProdutoProcessado.Show();
                    gbProdutoNatural.Hide();
                    break;
                case "Refeição Pronta":
                    txtPrefixoCodigo.Text = "RP";
                    gbRefeicaoPronta.Show();
                    gbProdutoProcessado.Show();
                    gbProdutoNatural.Hide();
                    break;
                default:
                    MensagemTipoDesconhecido();
                    break;
            }
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            double custo = Convert.ToDouble(numCustoSimular.Value);


            txtMargem.Text = CalcMargem(custo).ToString();
            txtPVP.Text = CalcPVP(custo).ToString();
        }

        public virtual double CalcMargem(double valor)
        {
            double resultado = 0;
            resultado = valor * 0.1;
            return resultado;
        }

        //Utilizado para calcular antes da criação de um produto
        public virtual double CalcPVP(double valor)
        {
            double resultado = 0;
            resultado = valor + CalcMargem(valor);
            return resultado;
        }

        private void numCustoSimular_ValueChanged(object sender, EventArgs e)
        {
            if(numCusto.Value != 0)
                numCustoSimular.Value = numCusto.Value;
        }
    }
}


