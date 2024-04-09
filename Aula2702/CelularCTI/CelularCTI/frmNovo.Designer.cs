namespace CelularCTI
{
    partial class frmNovo
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
			this.lblFabricante = new System.Windows.Forms.Label();
			this.lblModelo = new System.Windows.Forms.Label();
			this.lblLargura = new System.Windows.Forms.Label();
			this.lblAltura = new System.Windows.Forms.Label();
			this.lblEspessura = new System.Windows.Forms.Label();
			this.lblQuantidade = new System.Windows.Forms.Label();
			this.lblPeso = new System.Windows.Forms.Label();
			this.lblPreco = new System.Windows.Forms.Label();
			this.lblDesconto = new System.Windows.Forms.Label();
			this.cmbFabricante = new System.Windows.Forms.ComboBox();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.nudLargura = new System.Windows.Forms.NumericUpDown();
			this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
			this.nudPeso = new System.Windows.Forms.NumericUpDown();
			this.nudEspessura = new System.Windows.Forms.NumericUpDown();
			this.nudAltura = new System.Windows.Forms.NumericUpDown();
			this.nudPreco = new System.Windows.Forms.NumericUpDown();
			this.nudDesconto = new System.Windows.Forms.NumericUpDown();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudLargura)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudEspessura)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAltura)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPreco)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDesconto)).BeginInit();
			this.SuspendLayout();
			// 
			// lblFabricante
			// 
			this.lblFabricante.AutoSize = true;
			this.lblFabricante.Location = new System.Drawing.Point(13, 15);
			this.lblFabricante.Name = "lblFabricante";
			this.lblFabricante.Size = new System.Drawing.Size(63, 13);
			this.lblFabricante.TabIndex = 0;
			this.lblFabricante.Text = "Fabricante: ";
			// 
			// lblModelo
			// 
			this.lblModelo.AutoSize = true;
			this.lblModelo.Location = new System.Drawing.Point(13, 41);
			this.lblModelo.Name = "lblModelo";
			this.lblModelo.Size = new System.Drawing.Size(48, 13);
			this.lblModelo.TabIndex = 1;
			this.lblModelo.Text = "Modelo: ";
			// 
			// lblLargura
			// 
			this.lblLargura.AutoSize = true;
			this.lblLargura.Location = new System.Drawing.Point(13, 67);
			this.lblLargura.Name = "lblLargura";
			this.lblLargura.Size = new System.Drawing.Size(46, 13);
			this.lblLargura.TabIndex = 2;
			this.lblLargura.Text = "Largura:";
			// 
			// lblAltura
			// 
			this.lblAltura.AutoSize = true;
			this.lblAltura.Location = new System.Drawing.Point(13, 93);
			this.lblAltura.Name = "lblAltura";
			this.lblAltura.Size = new System.Drawing.Size(37, 13);
			this.lblAltura.TabIndex = 3;
			this.lblAltura.Text = "Altura:";
			// 
			// lblEspessura
			// 
			this.lblEspessura.AutoSize = true;
			this.lblEspessura.Location = new System.Drawing.Point(13, 119);
			this.lblEspessura.Name = "lblEspessura";
			this.lblEspessura.Size = new System.Drawing.Size(62, 13);
			this.lblEspessura.TabIndex = 4;
			this.lblEspessura.Text = "Espessura: ";
			// 
			// lblQuantidade
			// 
			this.lblQuantidade.AutoSize = true;
			this.lblQuantidade.Location = new System.Drawing.Point(13, 171);
			this.lblQuantidade.Name = "lblQuantidade";
			this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
			this.lblQuantidade.TabIndex = 5;
			this.lblQuantidade.Text = "Quantidade:";
			// 
			// lblPeso
			// 
			this.lblPeso.AutoSize = true;
			this.lblPeso.Location = new System.Drawing.Point(13, 145);
			this.lblPeso.Name = "lblPeso";
			this.lblPeso.Size = new System.Drawing.Size(34, 13);
			this.lblPeso.TabIndex = 6;
			this.lblPeso.Text = "Peso:";
			// 
			// lblPreco
			// 
			this.lblPreco.AutoSize = true;
			this.lblPreco.Location = new System.Drawing.Point(13, 197);
			this.lblPreco.Name = "lblPreco";
			this.lblPreco.Size = new System.Drawing.Size(64, 13);
			this.lblPreco.TabIndex = 7;
			this.lblPreco.Text = "Preço (R$): ";
			// 
			// lblDesconto
			// 
			this.lblDesconto.AutoSize = true;
			this.lblDesconto.Location = new System.Drawing.Point(13, 223);
			this.lblDesconto.Name = "lblDesconto";
			this.lblDesconto.Size = new System.Drawing.Size(59, 13);
			this.lblDesconto.TabIndex = 8;
			this.lblDesconto.Text = "Desconto: ";
			// 
			// cmbFabricante
			// 
			this.cmbFabricante.FormattingEnabled = true;
			this.cmbFabricante.Location = new System.Drawing.Point(81, 12);
			this.cmbFabricante.Name = "cmbFabricante";
			this.cmbFabricante.Size = new System.Drawing.Size(120, 21);
			this.cmbFabricante.TabIndex = 9;
			// 
			// txtModelo
			// 
			this.txtModelo.Location = new System.Drawing.Point(80, 41);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(120, 20);
			this.txtModelo.TabIndex = 10;
			// 
			// nudLargura
			// 
			this.nudLargura.Location = new System.Drawing.Point(81, 67);
			this.nudLargura.Name = "nudLargura";
			this.nudLargura.Size = new System.Drawing.Size(120, 20);
			this.nudLargura.TabIndex = 11;
			// 
			// nudQuantidade
			// 
			this.nudQuantidade.Location = new System.Drawing.Point(82, 171);
			this.nudQuantidade.Name = "nudQuantidade";
			this.nudQuantidade.Size = new System.Drawing.Size(120, 20);
			this.nudQuantidade.TabIndex = 12;
			// 
			// nudPeso
			// 
			this.nudPeso.Location = new System.Drawing.Point(81, 145);
			this.nudPeso.Name = "nudPeso";
			this.nudPeso.Size = new System.Drawing.Size(120, 20);
			this.nudPeso.TabIndex = 13;
			// 
			// nudEspessura
			// 
			this.nudEspessura.Location = new System.Drawing.Point(80, 119);
			this.nudEspessura.Name = "nudEspessura";
			this.nudEspessura.Size = new System.Drawing.Size(120, 20);
			this.nudEspessura.TabIndex = 14;
			// 
			// nudAltura
			// 
			this.nudAltura.Location = new System.Drawing.Point(80, 93);
			this.nudAltura.Name = "nudAltura";
			this.nudAltura.Size = new System.Drawing.Size(120, 20);
			this.nudAltura.TabIndex = 15;
			// 
			// nudPreco
			// 
			this.nudPreco.Location = new System.Drawing.Point(83, 197);
			this.nudPreco.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.nudPreco.Name = "nudPreco";
			this.nudPreco.Size = new System.Drawing.Size(120, 20);
			this.nudPreco.TabIndex = 16;
			// 
			// nudDesconto
			// 
			this.nudDesconto.Location = new System.Drawing.Point(82, 223);
			this.nudDesconto.Name = "nudDesconto";
			this.nudDesconto.Size = new System.Drawing.Size(120, 20);
			this.nudDesconto.TabIndex = 17;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(12, 276);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 23);
			this.btnSalvar.TabIndex = 18;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(147, 276);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 19;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// frmNovo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(234, 311);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.nudDesconto);
			this.Controls.Add(this.nudPreco);
			this.Controls.Add(this.nudAltura);
			this.Controls.Add(this.nudEspessura);
			this.Controls.Add(this.nudPeso);
			this.Controls.Add(this.nudQuantidade);
			this.Controls.Add(this.nudLargura);
			this.Controls.Add(this.txtModelo);
			this.Controls.Add(this.cmbFabricante);
			this.Controls.Add(this.lblDesconto);
			this.Controls.Add(this.lblPreco);
			this.Controls.Add(this.lblPeso);
			this.Controls.Add(this.lblQuantidade);
			this.Controls.Add(this.lblEspessura);
			this.Controls.Add(this.lblAltura);
			this.Controls.Add(this.lblLargura);
			this.Controls.Add(this.lblModelo);
			this.Controls.Add(this.lblFabricante);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmNovo";
			this.Text = "Novo Aparelho";
			this.Load += new System.EventHandler(this.frmNovo_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudLargura)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudEspessura)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAltura)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPreco)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDesconto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblLargura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblEspessura;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.NumericUpDown nudLargura;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.NumericUpDown nudPeso;
        private System.Windows.Forms.NumericUpDown nudEspessura;
        private System.Windows.Forms.NumericUpDown nudAltura;
        private System.Windows.Forms.NumericUpDown nudPreco;
        private System.Windows.Forms.NumericUpDown nudDesconto;
        private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnCancelar;
	}
}