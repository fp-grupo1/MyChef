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
        private BindingList<ProdutoAlimentar> listaDeProdutos;

        public NovoProduto(Form formPai, BindingList<ProdutoAlimentar> lista)
        {
            InitializeComponent();
            m_formPai = formPai;
            listaDeProdutos = lista;
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
    }
}
