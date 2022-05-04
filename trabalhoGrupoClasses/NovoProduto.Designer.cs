namespace trabalhoGrupoClasses
{
    partial class NovoProduto
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
            this.btnDistribuidores = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistoProduto = new System.Windows.Forms.Button();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.lblCusto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtCodigoID = new System.Windows.Forms.TextBox();
            this.lblCodigoID = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numProteinas = new System.Windows.Forms.NumericUpDown();
            this.numLipidos = new System.Windows.Forms.NumericUpDown();
            this.numHidratos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chAlergénios = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbBiologico = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numUnidades = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.numValidade = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbGourmet = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtModoPrep = new System.Windows.Forms.TextBox();
            this.numTempoPrep = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRegistarTipo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtPVP = new System.Windows.Forms.TextBox();
            this.txtMargem = new System.Windows.Forms.TextBox();
            this.btnCriarNovo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProteinas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLipidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHidratos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValidade)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTempoPrep)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDistribuidores
            // 
            this.btnDistribuidores.Location = new System.Drawing.Point(450, 545);
            this.btnDistribuidores.Margin = new System.Windows.Forms.Padding(2);
            this.btnDistribuidores.Name = "btnDistribuidores";
            this.btnDistribuidores.Size = new System.Drawing.Size(127, 45);
            this.btnDistribuidores.TabIndex = 104;
            this.btnDistribuidores.Text = "Informação Distribuidores";
            this.btnDistribuidores.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 19);
            this.label1.TabIndex = 102;
            this.label1.Text = "Introdução de Produto";
            // 
            // btnRegistoProduto
            // 
            this.btnRegistoProduto.Enabled = false;
            this.btnRegistoProduto.Location = new System.Drawing.Point(450, 495);
            this.btnRegistoProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistoProduto.Name = "btnRegistoProduto";
            this.btnRegistoProduto.Size = new System.Drawing.Size(128, 26);
            this.btnRegistoProduto.TabIndex = 101;
            this.btnRegistoProduto.Text = "Registar Produto";
            this.btnRegistoProduto.UseVisualStyleBackColor = true;
            this.btnRegistoProduto.Click += new System.EventHandler(this.btnRegistoProduto_Click);
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(126, 110);
            this.txtCusto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(87, 20);
            this.txtCusto.TabIndex = 100;
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusto.Location = new System.Drawing.Point(123, 91);
            this.lblCusto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(44, 16);
            this.lblCusto.TabIndex = 99;
            this.lblCusto.Text = "Custo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 98;
            this.label3.Text = "€";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(16, 110);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(2);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(87, 20);
            this.txtPeso.TabIndex = 96;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(126, 58);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(247, 20);
            this.txtNomeProduto.TabIndex = 95;
            // 
            // txtCodigoID
            // 
            this.txtCodigoID.Location = new System.Drawing.Point(16, 58);
            this.txtCodigoID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoID.Name = "txtCodigoID";
            this.txtCodigoID.Size = new System.Drawing.Size(81, 20);
            this.txtCodigoID.TabIndex = 94;
            // 
            // lblCodigoID
            // 
            this.lblCodigoID.AutoSize = true;
            this.lblCodigoID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoID.Location = new System.Drawing.Point(14, 38);
            this.lblCodigoID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoID.Name = "lblCodigoID";
            this.lblCodigoID.Size = new System.Drawing.Size(69, 16);
            this.lblCodigoID.TabIndex = 93;
            this.lblCodigoID.Text = "Código ID";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(123, 38);
            this.lblNomeProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(97, 16);
            this.lblNomeProduto.TabIndex = 92;
            this.lblNomeProduto.Text = "Nome Produto";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(14, 91);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(39, 16);
            this.lblPeso.TabIndex = 91;
            this.lblPeso.Text = "Peso";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Produto Natural",
            "Produto Processado",
            "Refeição Pronta"});
            this.cbTipo.Location = new System.Drawing.Point(16, 161);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(92, 21);
            this.cbTipo.TabIndex = 106;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numProteinas);
            this.groupBox1.Controls.Add(this.numLipidos);
            this.groupBox1.Controls.Add(this.numHidratos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.groupBox1.Location = new System.Drawing.Point(435, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(153, 232);
            this.groupBox1.TabIndex = 115;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores Nutricionais (100g)";
            // 
            // numProteinas
            // 
            this.numProteinas.DecimalPlaces = 2;
            this.numProteinas.Location = new System.Drawing.Point(10, 198);
            this.numProteinas.Margin = new System.Windows.Forms.Padding(2);
            this.numProteinas.Name = "numProteinas";
            this.numProteinas.Size = new System.Drawing.Size(90, 23);
            this.numProteinas.TabIndex = 115;
            // 
            // numLipidos
            // 
            this.numLipidos.DecimalPlaces = 2;
            this.numLipidos.Location = new System.Drawing.Point(11, 142);
            this.numLipidos.Margin = new System.Windows.Forms.Padding(2);
            this.numLipidos.Name = "numLipidos";
            this.numLipidos.Size = new System.Drawing.Size(90, 23);
            this.numLipidos.TabIndex = 114;
            // 
            // numHidratos
            // 
            this.numHidratos.DecimalPlaces = 2;
            this.numHidratos.Location = new System.Drawing.Point(11, 84);
            this.numHidratos.Margin = new System.Windows.Forms.Padding(2);
            this.numHidratos.Name = "numHidratos";
            this.numHidratos.Size = new System.Drawing.Size(90, 23);
            this.numHidratos.TabIndex = 113;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 107;
            this.label2.Text = "Hidratos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 109;
            this.label4.Text = "Lípidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 111;
            this.label5.Text = "Proteínas";
            // 
            // chAlergénios
            // 
            this.chAlergénios.AutoSize = true;
            this.chAlergénios.Location = new System.Drawing.Point(265, 112);
            this.chAlergénios.Margin = new System.Windows.Forms.Padding(2);
            this.chAlergénios.Name = "chAlergénios";
            this.chAlergénios.Size = new System.Drawing.Size(114, 17);
            this.chAlergénios.TabIndex = 116;
            this.chAlergénios.Text = "Contém Alergénios";
            this.chAlergénios.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.Location = new System.Drawing.Point(14, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 117;
            this.label6.Text = "Tipo de Produto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbBiologico);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtPais);
            this.groupBox2.Location = new System.Drawing.Point(11, 515);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(411, 126);
            this.groupBox2.TabIndex = 118;
            this.groupBox2.TabStop = false;
            // 
            // cbBiologico
            // 
            this.cbBiologico.AutoSize = true;
            this.cbBiologico.Enabled = false;
            this.cbBiologico.Location = new System.Drawing.Point(194, 36);
            this.cbBiologico.Margin = new System.Windows.Forms.Padding(2);
            this.cbBiologico.Name = "cbBiologico";
            this.cbBiologico.Size = new System.Drawing.Size(69, 17);
            this.cbBiologico.TabIndex = 117;
            this.cbBiologico.Text = "Biológico";
            this.cbBiologico.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 107;
            this.label7.Text = "País de Origem";
            // 
            // txtPais
            // 
            this.txtPais.Enabled = false;
            this.txtPais.Location = new System.Drawing.Point(14, 43);
            this.txtPais.Margin = new System.Windows.Forms.Padding(2);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(87, 20);
            this.txtPais.TabIndex = 108;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numUnidades);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtMarca);
            this.groupBox3.Controls.Add(this.numValidade);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(11, 384);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(411, 126);
            this.groupBox3.TabIndex = 119;
            this.groupBox3.TabStop = false;
            // 
            // numUnidades
            // 
            this.numUnidades.Enabled = false;
            this.numUnidades.Location = new System.Drawing.Point(194, 38);
            this.numUnidades.Margin = new System.Windows.Forms.Padding(2);
            this.numUnidades.Name = "numUnidades";
            this.numUnidades.Size = new System.Drawing.Size(90, 20);
            this.numUnidades.TabIndex = 122;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 120;
            this.label10.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(15, 37);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(87, 20);
            this.txtMarca.TabIndex = 121;
            // 
            // numValidade
            // 
            this.numValidade.Enabled = false;
            this.numValidade.Location = new System.Drawing.Point(16, 95);
            this.numValidade.Margin = new System.Windows.Forms.Padding(2);
            this.numValidade.Name = "numValidade";
            this.numValidade.Size = new System.Drawing.Size(90, 20);
            this.numValidade.TabIndex = 119;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 118;
            this.label9.Text = "Validade (dias)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(191, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 107;
            this.label8.Text = "Unid./Embalagem";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbGourmet);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtModoPrep);
            this.groupBox4.Controls.Add(this.numTempoPrep);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(11, 254);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(411, 126);
            this.groupBox4.TabIndex = 120;
            this.groupBox4.TabStop = false;
            // 
            // cbGourmet
            // 
            this.cbGourmet.AutoSize = true;
            this.cbGourmet.Enabled = false;
            this.cbGourmet.Location = new System.Drawing.Point(16, 83);
            this.cbGourmet.Margin = new System.Windows.Forms.Padding(2);
            this.cbGourmet.Name = "cbGourmet";
            this.cbGourmet.Size = new System.Drawing.Size(66, 17);
            this.cbGourmet.TabIndex = 122;
            this.cbGourmet.Text = "Gourmet";
            this.cbGourmet.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 18);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 16);
            this.label11.TabIndex = 120;
            this.label11.Text = "Modo de Preparação";
            // 
            // txtModoPrep
            // 
            this.txtModoPrep.Enabled = false;
            this.txtModoPrep.Location = new System.Drawing.Point(16, 39);
            this.txtModoPrep.Margin = new System.Windows.Forms.Padding(2);
            this.txtModoPrep.Name = "txtModoPrep";
            this.txtModoPrep.Size = new System.Drawing.Size(87, 20);
            this.txtModoPrep.TabIndex = 121;
            // 
            // numTempoPrep
            // 
            this.numTempoPrep.Enabled = false;
            this.numTempoPrep.Location = new System.Drawing.Point(194, 41);
            this.numTempoPrep.Margin = new System.Windows.Forms.Padding(2);
            this.numTempoPrep.Name = "numTempoPrep";
            this.numTempoPrep.Size = new System.Drawing.Size(90, 20);
            this.numTempoPrep.TabIndex = 119;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(191, 18);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(210, 16);
            this.label12.TabIndex = 118;
            this.label12.Text = "Tempo de Preparação (minutos)";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRegistarTipo);
            this.groupBox5.Controls.Add(this.lblCodigoID);
            this.groupBox5.Controls.Add(this.lblPeso);
            this.groupBox5.Controls.Add(this.lblNomeProduto);
            this.groupBox5.Controls.Add(this.txtCodigoID);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtNomeProduto);
            this.groupBox5.Controls.Add(this.chAlergénios);
            this.groupBox5.Controls.Add(this.txtPeso);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.cbTipo);
            this.groupBox5.Controls.Add(this.lblCusto);
            this.groupBox5.Controls.Add(this.txtCusto);
            this.groupBox5.Location = new System.Drawing.Point(11, 46);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(411, 196);
            this.groupBox5.TabIndex = 121;
            this.groupBox5.TabStop = false;
            // 
            // btnRegistarTipo
            // 
            this.btnRegistarTipo.Location = new System.Drawing.Point(168, 161);
            this.btnRegistarTipo.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistarTipo.Name = "btnRegistarTipo";
            this.btnRegistarTipo.Size = new System.Drawing.Size(140, 26);
            this.btnRegistarTipo.TabIndex = 118;
            this.btnRegistarTipo.Text = "Registar Tipo de Produto";
            this.btnRegistarTipo.UseVisualStyleBackColor = true;
            this.btnRegistarTipo.Click += new System.EventHandler(this.btnRegistarTipo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(9, 9);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(34, 27);
            this.btnAnterior.TabIndex = 122;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 16);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 16);
            this.label13.TabIndex = 119;
            this.label13.Text = "Margem";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 81);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 16);
            this.label14.TabIndex = 120;
            this.label14.Text = "PVP";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.btnCalcular);
            this.groupBox6.Controls.Add(this.txtPVP);
            this.groupBox6.Controls.Add(this.txtMargem);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Location = new System.Drawing.Point(437, 283);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(151, 187);
            this.groupBox6.TabIndex = 123;
            this.groupBox6.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(105, 104);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 125;
            this.label16.Text = "€";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(105, 37);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 124;
            this.label15.Text = "€";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(9, 134);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(109, 26);
            this.btnCalcular.TabIndex = 123;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtPVP
            // 
            this.txtPVP.Enabled = false;
            this.txtPVP.Location = new System.Drawing.Point(12, 101);
            this.txtPVP.Margin = new System.Windows.Forms.Padding(2);
            this.txtPVP.Name = "txtPVP";
            this.txtPVP.Size = new System.Drawing.Size(87, 20);
            this.txtPVP.TabIndex = 122;
            // 
            // txtMargem
            // 
            this.txtMargem.Enabled = false;
            this.txtMargem.Location = new System.Drawing.Point(12, 34);
            this.txtMargem.Margin = new System.Windows.Forms.Padding(2);
            this.txtMargem.Name = "txtMargem";
            this.txtMargem.Size = new System.Drawing.Size(87, 20);
            this.txtMargem.TabIndex = 121;
            // 
            // btnCriarNovo
            // 
            this.btnCriarNovo.Enabled = false;
            this.btnCriarNovo.Location = new System.Drawing.Point(449, 615);
            this.btnCriarNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btnCriarNovo.Name = "btnCriarNovo";
            this.btnCriarNovo.Size = new System.Drawing.Size(128, 26);
            this.btnCriarNovo.TabIndex = 124;
            this.btnCriarNovo.Text = "Criar novo Produto";
            this.btnCriarNovo.UseVisualStyleBackColor = true;
            this.btnCriarNovo.Click += new System.EventHandler(this.btnCriarNovo_Click);
            // 
            // NovoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 653);
            this.Controls.Add(this.btnCriarNovo);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDistribuidores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistoProduto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NovoProduto";
            this.Text = "Introdução de Produto";
            this.Load += new System.EventHandler(this.NovoProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProteinas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLipidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHidratos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValidade)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTempoPrep)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDistribuidores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistoProduto;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtCodigoID;
        private System.Windows.Forms.Label lblCodigoID;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chAlergénios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.CheckBox cbBiologico;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.NumericUpDown numValidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtModoPrep;
        private System.Windows.Forms.NumericUpDown numTempoPrep;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbGourmet;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown numProteinas;
        private System.Windows.Forms.NumericUpDown numLipidos;
        private System.Windows.Forms.NumericUpDown numHidratos;
        private System.Windows.Forms.NumericUpDown numUnidades;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnRegistarTipo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtPVP;
        private System.Windows.Forms.TextBox txtMargem;
        private System.Windows.Forms.Button btnCriarNovo;
    }
}