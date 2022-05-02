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

        public Home()
        {
            InitializeComponent();
        }

        private void btnInformacaoDistribuidores_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnDistribuidores_Click(object sender, EventArgs e)
        {
            formDistribuidores = new Distribuidores(this);

            formDistribuidores.Location = this.Location;
            this.Hide();
            formDistribuidores.Show();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            formNovoProduto = new NovoProduto(this);

            formNovoProduto.Location = this.Location;
            this.Hide();
            formNovoProduto.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            formEditarProduto = new EditarProduto(this);

            formEditarProduto.Location = this.Location;
            this.Hide();
            formEditarProduto.Show();
        }
    }
}
