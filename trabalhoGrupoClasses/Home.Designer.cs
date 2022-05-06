namespace trabalhoGrupoClasses
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.idCodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vMLipidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vMHidratosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alergeniosDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDistribuidoresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDistribuidorPrincipalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numMaxDistribuidoresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoAlimentarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDistribuidores = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProdNaturais = new System.Windows.Forms.CheckBox();
            this.cbProdProcessados = new System.Windows.Forms.CheckBox();
            this.cbRefPronta = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtCodigoID = new System.Windows.Forms.TextBox();
            this.lblCodigoID = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblMyChef = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInfoNutricinal = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoAlimentarBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgProdutos
            // 
            this.dgProdutos.AllowUserToAddRows = false;
            this.dgProdutos.AllowUserToDeleteRows = false;
            this.dgProdutos.AutoGenerateColumns = false;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCodDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.custoDataGridViewTextBoxColumn,
            this.tipoDeProduto,
            this.vMLipidosDataGridViewTextBoxColumn,
            this.vMHidratosDataGridViewTextBoxColumn,
            this.alergeniosDataGridViewCheckBoxColumn,
            this.pesoDataGridViewTextBoxColumn,
            this.numDistribuidoresDataGridViewTextBoxColumn,
            this.nomeDistribuidorPrincipalDataGridViewTextBoxColumn,
            this.numMaxDistribuidoresDataGridViewTextBoxColumn});
            this.dgProdutos.DataSource = this.produtoAlimentarBindingSource;
            this.dgProdutos.Location = new System.Drawing.Point(4, 12);
            this.dgProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.dgProdutos.MultiSelect = false;
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.RowHeadersVisible = false;
            this.dgProdutos.RowHeadersWidth = 51;
            this.dgProdutos.RowTemplate.Height = 24;
            this.dgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProdutos.Size = new System.Drawing.Size(511, 266);
            this.dgProdutos.TabIndex = 91;
            this.dgProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProdutos_CellContentClick);
            // 
            // idCodDataGridViewTextBoxColumn
            // 
            this.idCodDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idCodDataGridViewTextBoxColumn.DataPropertyName = "IdCod";
            dataGridViewCellStyle1.Format = "string";
            dataGridViewCellStyle1.NullValue = "\"\"";
            this.idCodDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idCodDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.idCodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCodDataGridViewTextBoxColumn.Name = "idCodDataGridViewTextBoxColumn";
            this.idCodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // custoDataGridViewTextBoxColumn
            // 
            this.custoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.custoDataGridViewTextBoxColumn.DataPropertyName = "Custo";
            this.custoDataGridViewTextBoxColumn.HeaderText = "Custo";
            this.custoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custoDataGridViewTextBoxColumn.Name = "custoDataGridViewTextBoxColumn";
            // 
            // tipoDeProduto
            // 
            this.tipoDeProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoDeProduto.HeaderText = "Tipo";
            this.tipoDeProduto.Name = "tipoDeProduto";
            // 
            // vMLipidosDataGridViewTextBoxColumn
            // 
            this.vMLipidosDataGridViewTextBoxColumn.DataPropertyName = "VMLipidos";
            this.vMLipidosDataGridViewTextBoxColumn.HeaderText = "VMLipidos";
            this.vMLipidosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vMLipidosDataGridViewTextBoxColumn.Name = "vMLipidosDataGridViewTextBoxColumn";
            this.vMLipidosDataGridViewTextBoxColumn.Visible = false;
            this.vMLipidosDataGridViewTextBoxColumn.Width = 125;
            // 
            // vMHidratosDataGridViewTextBoxColumn
            // 
            this.vMHidratosDataGridViewTextBoxColumn.DataPropertyName = "VMHidratos";
            this.vMHidratosDataGridViewTextBoxColumn.HeaderText = "VMHidratos";
            this.vMHidratosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vMHidratosDataGridViewTextBoxColumn.Name = "vMHidratosDataGridViewTextBoxColumn";
            this.vMHidratosDataGridViewTextBoxColumn.Visible = false;
            this.vMHidratosDataGridViewTextBoxColumn.Width = 125;
            // 
            // alergeniosDataGridViewCheckBoxColumn
            // 
            this.alergeniosDataGridViewCheckBoxColumn.DataPropertyName = "Alergenios";
            this.alergeniosDataGridViewCheckBoxColumn.HeaderText = "Alergenios";
            this.alergeniosDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.alergeniosDataGridViewCheckBoxColumn.Name = "alergeniosDataGridViewCheckBoxColumn";
            this.alergeniosDataGridViewCheckBoxColumn.Visible = false;
            this.alergeniosDataGridViewCheckBoxColumn.Width = 125;
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            this.pesoDataGridViewTextBoxColumn.DataPropertyName = "Peso";
            this.pesoDataGridViewTextBoxColumn.HeaderText = "Peso";
            this.pesoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            this.pesoDataGridViewTextBoxColumn.Visible = false;
            this.pesoDataGridViewTextBoxColumn.Width = 125;
            // 
            // numDistribuidoresDataGridViewTextBoxColumn
            // 
            this.numDistribuidoresDataGridViewTextBoxColumn.DataPropertyName = "NumDistribuidores";
            this.numDistribuidoresDataGridViewTextBoxColumn.HeaderText = "NumDistribuidores";
            this.numDistribuidoresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numDistribuidoresDataGridViewTextBoxColumn.Name = "numDistribuidoresDataGridViewTextBoxColumn";
            this.numDistribuidoresDataGridViewTextBoxColumn.ReadOnly = true;
            this.numDistribuidoresDataGridViewTextBoxColumn.Visible = false;
            this.numDistribuidoresDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDistribuidorPrincipalDataGridViewTextBoxColumn
            // 
            this.nomeDistribuidorPrincipalDataGridViewTextBoxColumn.DataPropertyName = "NomeDistribuidorPrincipal";
            this.nomeDistribuidorPrincipalDataGridViewTextBoxColumn.HeaderText = "NomeDistribuidorPrincipal";
            this.nomeDistribuidorPrincipalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDistribuidorPrincipalDataGridViewTextBoxColumn.Name = "nomeDistribuidorPrincipalDataGridViewTextBoxColumn";
            this.nomeDistribuidorPrincipalDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDistribuidorPrincipalDataGridViewTextBoxColumn.Visible = false;
            this.nomeDistribuidorPrincipalDataGridViewTextBoxColumn.Width = 125;
            // 
            // numMaxDistribuidoresDataGridViewTextBoxColumn
            // 
            this.numMaxDistribuidoresDataGridViewTextBoxColumn.DataPropertyName = "NumMaxDistribuidores";
            this.numMaxDistribuidoresDataGridViewTextBoxColumn.HeaderText = "NumMaxDistribuidores";
            this.numMaxDistribuidoresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numMaxDistribuidoresDataGridViewTextBoxColumn.Name = "numMaxDistribuidoresDataGridViewTextBoxColumn";
            this.numMaxDistribuidoresDataGridViewTextBoxColumn.ReadOnly = true;
            this.numMaxDistribuidoresDataGridViewTextBoxColumn.Visible = false;
            this.numMaxDistribuidoresDataGridViewTextBoxColumn.Width = 125;
            // 
            // produtoAlimentarBindingSource
            // 
            this.produtoAlimentarBindingSource.DataSource = typeof(trabalhoGrupoClasses.ProdutoAlimentar);
            // 
            // btnDistribuidores
            // 
            this.btnDistribuidores.Location = new System.Drawing.Point(519, 146);
            this.btnDistribuidores.Margin = new System.Windows.Forms.Padding(2);
            this.btnDistribuidores.Name = "btnDistribuidores";
            this.btnDistribuidores.Size = new System.Drawing.Size(93, 26);
            this.btnDistribuidores.TabIndex = 90;
            this.btnDistribuidores.Text = "Distribuidores";
            this.btnDistribuidores.UseVisualStyleBackColor = true;
            this.btnDistribuidores.Click += new System.EventHandler(this.btnDistribuidores_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 88;
            this.label2.Text = "Listagem de produtos";
            // 
            // cbProdNaturais
            // 
            this.cbProdNaturais.AutoSize = true;
            this.cbProdNaturais.Location = new System.Drawing.Point(8, 57);
            this.cbProdNaturais.Margin = new System.Windows.Forms.Padding(2);
            this.cbProdNaturais.Name = "cbProdNaturais";
            this.cbProdNaturais.Size = new System.Drawing.Size(110, 17);
            this.cbProdNaturais.TabIndex = 87;
            this.cbProdNaturais.Text = "Produtos Naturais";
            this.cbProdNaturais.UseVisualStyleBackColor = true;
            // 
            // cbProdProcessados
            // 
            this.cbProdProcessados.AutoSize = true;
            this.cbProdProcessados.Location = new System.Drawing.Point(139, 57);
            this.cbProdProcessados.Margin = new System.Windows.Forms.Padding(2);
            this.cbProdProcessados.Name = "cbProdProcessados";
            this.cbProdProcessados.Size = new System.Drawing.Size(132, 17);
            this.cbProdProcessados.TabIndex = 86;
            this.cbProdProcessados.Text = "Produtos Processados";
            this.cbProdProcessados.UseVisualStyleBackColor = true;
            // 
            // cbRefPronta
            // 
            this.cbRefPronta.AutoSize = true;
            this.cbRefPronta.Location = new System.Drawing.Point(290, 57);
            this.cbRefPronta.Margin = new System.Windows.Forms.Padding(2);
            this.cbRefPronta.Name = "cbRefPronta";
            this.cbRefPronta.Size = new System.Drawing.Size(103, 17);
            this.cbRefPronta.TabIndex = 85;
            this.cbRefPronta.Text = "Refeição Pronta";
            this.cbRefPronta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 84;
            this.label1.Text = "Produtos";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(518, 28);
            this.btnPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(68, 26);
            this.btnPesquisa.TabIndex = 79;
            this.btnPesquisa.Text = "Pesquisa";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(268, 32);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(247, 20);
            this.txtNomeProduto.TabIndex = 77;
            // 
            // txtCodigoID
            // 
            this.txtCodigoID.Location = new System.Drawing.Point(8, 30);
            this.txtCodigoID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoID.Name = "txtCodigoID";
            this.txtCodigoID.Size = new System.Drawing.Size(81, 20);
            this.txtCodigoID.TabIndex = 76;
            // 
            // lblCodigoID
            // 
            this.lblCodigoID.AutoSize = true;
            this.lblCodigoID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoID.Location = new System.Drawing.Point(4, 13);
            this.lblCodigoID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoID.Name = "lblCodigoID";
            this.lblCodigoID.Size = new System.Drawing.Size(69, 16);
            this.lblCodigoID.TabIndex = 75;
            this.lblCodigoID.Text = "Código ID";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(265, 15);
            this.lblNomeProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(97, 16);
            this.lblNomeProduto.TabIndex = 74;
            this.lblNomeProduto.Text = "Nome Produto";
            // 
            // lblMyChef
            // 
            this.lblMyChef.AutoSize = true;
            this.lblMyChef.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyChef.Location = new System.Drawing.Point(16, 18);
            this.lblMyChef.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMyChef.Name = "lblMyChef";
            this.lblMyChef.Size = new System.Drawing.Size(86, 22);
            this.lblMyChef.TabIndex = 72;
            this.lblMyChef.Text = "My Chef";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInfoNutricinal);
            this.groupBox1.Controls.Add(this.btnApagar);
            this.groupBox1.Controls.Add(this.btnDistribuidores);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.dgProdutos);
            this.groupBox1.Location = new System.Drawing.Point(0, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(618, 282);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            // 
            // btnInfoNutricinal
            // 
            this.btnInfoNutricinal.Location = new System.Drawing.Point(519, 176);
            this.btnInfoNutricinal.Margin = new System.Windows.Forms.Padding(2);
            this.btnInfoNutricinal.Name = "btnInfoNutricinal";
            this.btnInfoNutricinal.Size = new System.Drawing.Size(93, 26);
            this.btnInfoNutricinal.TabIndex = 95;
            this.btnInfoNutricinal.Text = "Info Nutricional";
            this.btnInfoNutricinal.UseVisualStyleBackColor = true;
            this.btnInfoNutricinal.Click += new System.EventHandler(this.btnInfoNutricinal_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(519, 55);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(93, 26);
            this.btnApagar.TabIndex = 94;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(519, 16);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(93, 26);
            this.btnEditar.TabIndex = 93;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(519, 252);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(93, 26);
            this.btnNovo.TabIndex = 92;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCodigoID);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.lblNomeProduto);
            this.groupBox2.Controls.Add(this.txtCodigoID);
            this.groupBox2.Controls.Add(this.txtNomeProduto);
            this.groupBox2.Controls.Add(this.cbRefPronta);
            this.groupBox2.Controls.Add(this.btnPesquisa);
            this.groupBox2.Controls.Add(this.cbProdProcessados);
            this.groupBox2.Controls.Add(this.cbProdNaturais);
            this.groupBox2.Location = new System.Drawing.Point(21, 91);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(742, 359);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 470);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMyChef);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "MyChef";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoAlimentarBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.Button btnDistribuidores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbProdNaturais;
        private System.Windows.Forms.CheckBox cbProdProcessados;
        private System.Windows.Forms.CheckBox cbRefPronta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtCodigoID;
        private System.Windows.Forms.Label lblCodigoID;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblMyChef;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource produtoAlimentarBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn vMProteinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vMLipidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vMHidratosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn alergeniosDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDistribuidoresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDistribuidorPrincipalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numMaxDistribuidoresDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnInfoNutricinal;
    }
}