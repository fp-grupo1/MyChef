﻿using System;
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
    public partial class InfoNutricional : Form
    {
        private Form m_formPai;
        private ProdutoAlimentar produtoAMostrar;

        public InfoNutricional(Form formPai, ProdutoAlimentar umProdutoAMostrar)
        {
            InitializeComponent();
            m_formPai = formPai;
            produtoAMostrar = umProdutoAMostrar;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            m_formPai.Location = this.Location;
            this.Hide();
            m_formPai.Show();
        }

        private void InfoNutricional_Load(object sender, EventArgs e)
        {

        }
    }
}
