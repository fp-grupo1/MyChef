namespace trabalhoGrupoClasses
{
    partial class Distribuidores
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
            this.btnAnterior = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCustoNovoProd = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNomeNovoDistrib = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNovoDistrib = new System.Windows.Forms.Button();
            this.lblDistribuidores = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumDistrib = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCustoProd = new System.Windows.Forms.TextBox();
            this.txtNomeDistrib = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustoNovoProd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(21, 22);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(45, 33);
            this.btnAnterior.TabIndex = 89;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnNovoDistrib);
            this.groupBox1.Location = new System.Drawing.Point(24, 339);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(828, 157);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar novo Distribuidor";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCustoNovoProd);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtNomeNovoDistrib);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(266, 31);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(538, 102);
            this.groupBox3.TabIndex = 87;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "(opcional)";
            // 
            // txtCustoNovoProd
            // 
            this.txtCustoNovoProd.Location = new System.Drawing.Point(389, 58);
            this.txtCustoNovoProd.Name = "txtCustoNovoProd";
            this.txtCustoNovoProd.Size = new System.Drawing.Size(120, 22);
            this.txtCustoNovoProd.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(737, 57);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 29);
            this.button1.TabIndex = 40;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtNomeNovoDistrib
            // 
            this.txtNomeNovoDistrib.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeNovoDistrib.ForeColor = System.Drawing.Color.Silver;
            this.txtNomeNovoDistrib.Location = new System.Drawing.Point(16, 57);
            this.txtNomeNovoDistrib.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeNovoDistrib.Name = "txtNomeNovoDistrib";
            this.txtNomeNovoDistrib.Size = new System.Drawing.Size(328, 23);
            this.txtNomeNovoDistrib.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(385, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 19);
            this.label8.TabIndex = 34;
            this.label8.Text = "Custo do Produto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "Nome do Distribuidor";
            // 
            // btnNovoDistrib
            // 
            this.btnNovoDistrib.Location = new System.Drawing.Point(15, 48);
            this.btnNovoDistrib.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNovoDistrib.Name = "btnNovoDistrib";
            this.btnNovoDistrib.Size = new System.Drawing.Size(76, 29);
            this.btnNovoDistrib.TabIndex = 40;
            this.btnNovoDistrib.Text = "Inserir";
            this.btnNovoDistrib.UseVisualStyleBackColor = true;
            // 
            // lblDistribuidores
            // 
            this.lblDistribuidores.AutoSize = true;
            this.lblDistribuidores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistribuidores.Location = new System.Drawing.Point(93, 31);
            this.lblDistribuidores.Name = "lblDistribuidores";
            this.lblDistribuidores.Size = new System.Drawing.Size(143, 24);
            this.lblDistribuidores.TabIndex = 77;
            this.lblDistribuidores.Text = "Distribuidores";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(163, 63);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.ReadOnly = true;
            this.txtNomeProduto.Size = new System.Drawing.Size(328, 22);
            this.txtNomeProduto.TabIndex = 93;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(20, 63);
            this.txtIdProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.ReadOnly = true;
            this.txtIdProduto.Size = new System.Drawing.Size(107, 22);
            this.txtIdProduto.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 19);
            this.label2.TabIndex = 91;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 90;
            this.label3.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNumDistrib);
            this.groupBox2.Controls.Add(this.txtNomeProduto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtIdProduto);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(24, 85);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(828, 110);
            this.groupBox2.TabIndex = 87;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(656, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "(máx 10)";
            // 
            // txtNumDistrib
            // 
            this.txtNumDistrib.Location = new System.Drawing.Point(536, 62);
            this.txtNumDistrib.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumDistrib.Name = "txtNumDistrib";
            this.txtNumDistrib.ReadOnly = true;
            this.txtNumDistrib.Size = new System.Drawing.Size(115, 22);
            this.txtNumDistrib.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(534, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "Número de Distribuidores";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCustoProd);
            this.groupBox4.Controls.Add(this.txtNomeDistrib);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(24, 214);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(828, 110);
            this.groupBox4.TabIndex = 94;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Distribuidor Principal";
            // 
            // txtCustoProd
            // 
            this.txtCustoProd.Location = new System.Drawing.Point(396, 63);
            this.txtCustoProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustoProd.Name = "txtCustoProd";
            this.txtCustoProd.ReadOnly = true;
            this.txtCustoProd.Size = new System.Drawing.Size(115, 22);
            this.txtCustoProd.TabIndex = 94;
            // 
            // txtNomeDistrib
            // 
            this.txtNomeDistrib.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDistrib.ForeColor = System.Drawing.Color.Silver;
            this.txtNomeDistrib.Location = new System.Drawing.Point(23, 63);
            this.txtNomeDistrib.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeDistrib.Name = "txtNomeDistrib";
            this.txtNomeDistrib.ReadOnly = true;
            this.txtNomeDistrib.Size = new System.Drawing.Size(328, 23);
            this.txtNomeDistrib.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 19);
            this.label4.TabIndex = 42;
            this.label4.Text = "Custo do Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 19);
            this.label5.TabIndex = 43;
            this.label5.Text = "Nome do Distribuidor";
            // 
            // Distribuidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 519);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDistribuidores);
            this.Name = "Distribuidores";
            this.Text = "Distribuidores";
            this.Load += new System.EventHandler(this.Distribuidores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustoNovoProd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNovoDistrib;
        private System.Windows.Forms.TextBox txtNomeNovoDistrib;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDistribuidores;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown txtCustoNovoProd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumDistrib;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCustoProd;
        private System.Windows.Forms.TextBox txtNomeDistrib;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}