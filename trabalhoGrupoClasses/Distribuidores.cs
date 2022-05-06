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

        private ProdutoAlimentar umProduto;

        public Distribuidores(Form formPai, ProdutoAlimentar produto)
        {
            InitializeComponent();
            m_formPai = formPai;
            umProduto = produto;

        }

        private void Distribuidores_Load(object sender, EventArgs e)
        {
            PopularCampos();
        }

        public void PopularCampos()
        {
            txtIdProduto.Text = umProduto.IdCod;
            txtNomeProduto.Text = umProduto.Nome;
            txtNumDistrib.Text = umProduto.NumDistribuidores.ToString();
            lblnumDist.Text = "(máx: " + umProduto.NumMaxDistribuidores.ToString() + ")";

            txtNomeDistrib.Text = umProduto.NomeDistribuidorPrincipal;
            txtCustoProd.Text = umProduto.Custo.ToString();
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
                if (umProduto.RegistarDistribuidor(nome, custo))
                {
                    MessageBox.Show("Distribuidor registado com sucesso.");
                }
                else MessageBox.Show("Distribuidor não foi registado.");
            }
            else if (umProduto.RegistarDistribuidor())
            {
                MessageBox.Show("Distribuidor registado com sucesso.");
            }
            else MessageBox.Show("Distribuidor não foi registado.");

            PopularCampos();

        }
    }
}
