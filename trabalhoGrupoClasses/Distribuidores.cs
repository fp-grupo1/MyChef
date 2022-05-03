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
    public partial class Distribuidores : Form
    {
        private Form m_formPai;
        ProdutoNatural produtotestedist = new ProdutoNatural("natural23", "produtoteste", 500);

        public Distribuidores(Form formPai)
        {
            InitializeComponent();
            m_formPai = formPai;
        }

        private void Distribuidores_Load(object sender, EventArgs e)
        {
            PopularCampos();
        }

        public void PopularCampos()
        {
            txtIdProduto.Text = produtotestedist.IdCod;
            txtNomeProduto.Text = produtotestedist.Nome;
            txtNumDistrib.Text = produtotestedist.NumDistribuidores.ToString();
            lblnumDist.Text = "(máx: " + produtotestedist.NumMaxDistribuidores.ToString() + ")";

            txtNomeDistrib.Text = produtotestedist.NomeDistribuidorPrincipal;
            txtCustoProd.Text = produtotestedist.Custo.ToString();            
        }


        private void btnAnterior_Click(object sender, EventArgs e)
        {
            m_formPai.Location = this.Location;
            this.Hide();
            m_formPai.Show();
        }

        private void btnNovoDistrib_Click(object sender, EventArgs e)
        {
            string nome = txtNomeNovoDistrib.Text;
            double custo = Convert.ToDouble(txtCustoNovoProd.Value);

            if (nome.Length > 0 && custo > 0)
            {
                if (produtotestedist.RegistarDistribuidor(nome, custo))
                {
                    MessageBox.Show("Distribuidor registado com sucesso.");
                }
                else MessageBox.Show("Distribuidor não foi registado.");
            }
            else if (produtotestedist.RegistarDistribuidor())
            {
                MessageBox.Show("Distribuidor registado com sucesso.");
            }
            else MessageBox.Show("Distribuidor não foi registado.");

            PopularCampos();

        }
    }
}
