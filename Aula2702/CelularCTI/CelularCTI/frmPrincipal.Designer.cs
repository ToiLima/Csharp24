namespace CelularCTI
{
	partial class frmPrincipal
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
            this.gboPesquisa = new System.Windows.Forms.GroupBox();
            this.btnLstTodos = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.numPrecoMax = new System.Windows.Forms.NumericUpDown();
            this.btnFabricante = new System.Windows.Forms.Button();
            this.btnModelo = new System.Windows.Forms.Button();
            this.btnPreco = new System.Windows.Forms.Button();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.numPrecoMin = new System.Windows.Forms.NumericUpDown();
            this.gboCelulares = new System.Windows.Forms.GroupBox();
            this.lstCelular = new System.Windows.Forms.ListBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gboPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoMin)).BeginInit();
            this.gboCelulares.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboPesquisa
            // 
            this.gboPesquisa.Controls.Add(this.btnLstTodos);
            this.gboPesquisa.Controls.Add(this.lblA);
            this.gboPesquisa.Controls.Add(this.numPrecoMax);
            this.gboPesquisa.Controls.Add(this.btnFabricante);
            this.gboPesquisa.Controls.Add(this.btnModelo);
            this.gboPesquisa.Controls.Add(this.btnPreco);
            this.gboPesquisa.Controls.Add(this.lblFabricante);
            this.gboPesquisa.Controls.Add(this.lblModelo);
            this.gboPesquisa.Controls.Add(this.lblPreco);
            this.gboPesquisa.Controls.Add(this.cmbFabricante);
            this.gboPesquisa.Controls.Add(this.txtModelo);
            this.gboPesquisa.Controls.Add(this.numPrecoMin);
            this.gboPesquisa.Location = new System.Drawing.Point(14, 16);
            this.gboPesquisa.Name = "gboPesquisa";
            this.gboPesquisa.Size = new System.Drawing.Size(600, 124);
            this.gboPesquisa.TabIndex = 0;
            this.gboPesquisa.TabStop = false;
            this.gboPesquisa.Text = "Pesquisar por";
            // 
            // btnLstTodos
            // 
            this.btnLstTodos.Location = new System.Drawing.Point(519, 95);
            this.btnLstTodos.Name = "btnLstTodos";
            this.btnLstTodos.Size = new System.Drawing.Size(75, 23);
            this.btnLstTodos.TabIndex = 6;
            this.btnLstTodos.Text = "Listar Todos";
            this.btnLstTodos.UseVisualStyleBackColor = true;
            this.btnLstTodos.Click += new System.EventHandler(this.btnLstTodos_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(275, 21);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(13, 13);
            this.lblA.TabIndex = 10;
            this.lblA.Text = "a";
            // 
            // numPrecoMax
            // 
            this.numPrecoMax.Location = new System.Drawing.Point(307, 19);
            this.numPrecoMax.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numPrecoMax.Name = "numPrecoMax";
            this.numPrecoMax.Size = new System.Drawing.Size(190, 20);
            this.numPrecoMax.TabIndex = 9;
            // 
            // btnFabricante
            // 
            this.btnFabricante.Location = new System.Drawing.Point(519, 71);
            this.btnFabricante.Name = "btnFabricante";
            this.btnFabricante.Size = new System.Drawing.Size(75, 21);
            this.btnFabricante.TabIndex = 8;
            this.btnFabricante.Text = ">";
            this.btnFabricante.UseVisualStyleBackColor = true;
            this.btnFabricante.Click += new System.EventHandler(this.btnFabricante_Click);
            // 
            // btnModelo
            // 
            this.btnModelo.Location = new System.Drawing.Point(519, 45);
            this.btnModelo.Name = "btnModelo";
            this.btnModelo.Size = new System.Drawing.Size(75, 20);
            this.btnModelo.TabIndex = 7;
            this.btnModelo.Text = ">";
            this.btnModelo.UseVisualStyleBackColor = true;
            this.btnModelo.Click += new System.EventHandler(this.btnModelo_Click);
            // 
            // btnPreco
            // 
            this.btnPreco.Location = new System.Drawing.Point(519, 19);
            this.btnPreco.Name = "btnPreco";
            this.btnPreco.Size = new System.Drawing.Size(75, 20);
            this.btnPreco.TabIndex = 6;
            this.btnPreco.Text = ">";
            this.btnPreco.UseVisualStyleBackColor = true;
            this.btnPreco.Click += new System.EventHandler(this.btnPreco_Click);
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(6, 79);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(57, 13);
            this.lblFabricante.TabIndex = 5;
            this.lblFabricante.Text = "Fabricante";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(13, 52);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Modelo";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(13, 26);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 3;
            this.lblPreco.Text = "Preço";
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(69, 71);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(428, 21);
            this.cmbFabricante.TabIndex = 2;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(69, 45);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(428, 20);
            this.txtModelo.TabIndex = 1;
            // 
            // numPrecoMin
            // 
            this.numPrecoMin.Location = new System.Drawing.Point(69, 19);
            this.numPrecoMin.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numPrecoMin.Name = "numPrecoMin";
            this.numPrecoMin.Size = new System.Drawing.Size(190, 20);
            this.numPrecoMin.TabIndex = 0;
            // 
            // gboCelulares
            // 
            this.gboCelulares.Controls.Add(this.lstCelular);
            this.gboCelulares.Location = new System.Drawing.Point(14, 146);
            this.gboCelulares.Name = "gboCelulares";
            this.gboCelulares.Size = new System.Drawing.Size(525, 175);
            this.gboCelulares.TabIndex = 0;
            this.gboCelulares.TabStop = false;
            this.gboCelulares.Text = "Celulares";
            // 
            // lstCelular
            // 
            this.lstCelular.FormatString = "C2";
            this.lstCelular.Location = new System.Drawing.Point(9, 19);
            this.lstCelular.Name = "lstCelular";
            this.lstCelular.Size = new System.Drawing.Size(500, 147);
            this.lstCelular.TabIndex = 0;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(545, 155);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 3;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click_1);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(545, 184);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(545, 213);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 336);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.gboCelulares);
            this.Controls.Add(this.gboPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Lista de Celulares";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.gboPesquisa.ResumeLayout(false);
            this.gboPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoMin)).EndInit();
            this.gboCelulares.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gboPesquisa;
		private System.Windows.Forms.GroupBox gboCelulares;
		private System.Windows.Forms.Button btnFabricante;
		private System.Windows.Forms.Button btnModelo;
		private System.Windows.Forms.Button btnPreco;
		private System.Windows.Forms.Label lblFabricante;
		private System.Windows.Forms.Label lblModelo;
		private System.Windows.Forms.Label lblPreco;
		private System.Windows.Forms.ComboBox cmbFabricante;
		private System.Windows.Forms.TextBox txtModelo;
		private System.Windows.Forms.NumericUpDown numPrecoMin;
		private System.Windows.Forms.ListBox lstCelular;
		private System.Windows.Forms.NumericUpDown numPrecoMax;
		private System.Windows.Forms.Label lblA;
		private System.Windows.Forms.Button btnComprar;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btnLstTodos;
	}
}

