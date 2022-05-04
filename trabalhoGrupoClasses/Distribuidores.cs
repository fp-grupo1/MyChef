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

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            m_formPai.Location = this.Location;
            this.Hide();
            m_formPai.Show();
        }
    }
}
