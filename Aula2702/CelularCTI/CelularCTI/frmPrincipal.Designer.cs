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
            this.lbl4 = new System.Windows.Forms.Label();
            this.nudPrecoMax = new System.Windows.Forms.NumericUpDown();
            this.btnFabricante = new System.Windows.Forms.Button();
            this.btnModelo = new System.Windows.Forms.Button();
            this.btnPreco = new System.Windows.Forms.Button();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.nudPrecoMin = new System.Windows.Forms.NumericUpDown();
            this.gboCelulares = new System.Windows.Forms.GroupBox();
            this.lstCelular = new System.Windows.Forms.ListBox();
            this.gboPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoMin)).BeginInit();
            this.gboCelulares.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboPesquisa
            // 
            this.gboPesquisa.Controls.Add(this.lbl4);
            this.gboPesquisa.Controls.Add(this.nudPrecoMax);
            this.gboPesquisa.Controls.Add(this.btnFabricante);
            this.gboPesquisa.Controls.Add(this.btnModelo);
            this.gboPesquisa.Controls.Add(this.btnPreco);
            this.gboPesquisa.Controls.Add(this.lblFabricante);
            this.gboPesquisa.Controls.Add(this.lblModelo);
            this.gboPesquisa.Controls.Add(this.lblPreco);
            this.gboPesquisa.Controls.Add(this.cmbFabricante);
            this.gboPesquisa.Controls.Add(this.txtModelo);
            this.gboPesquisa.Controls.Add(this.nudPrecoMin);
            this.gboPesquisa.Location = new System.Drawing.Point(12, 12);
            this.gboPesquisa.Name = "gboPesquisa";
            this.gboPesquisa.Size = new System.Drawing.Size(600, 124);
            this.gboPesquisa.TabIndex = 0;
            this.gboPesquisa.TabStop = false;
            this.gboPesquisa.Text = "Pesquisar por";
            this.gboPesquisa.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(279, 21);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(13, 13);
            this.lbl4.TabIndex = 10;
            this.lbl4.Text = "a";
            this.lbl4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nudPrecoMax
            // 
            this.nudPrecoMax.Location = new System.Drawing.Point(307, 19);
            this.nudPrecoMax.Name = "nudPrecoMax";
            this.nudPrecoMax.Size = new System.Drawing.Size(190, 20);
            this.nudPrecoMax.TabIndex = 9;
            // 
            // btnFabricante
            // 
            this.btnFabricante.Location = new System.Drawing.Point(519, 70);
            this.btnFabricante.Name = "btnFabricante";
            this.btnFabricante.Size = new System.Drawing.Size(75, 21);
            this.btnFabricante.TabIndex = 8;
            this.btnFabricante.Text = ">";
            this.btnFabricante.UseVisualStyleBackColor = true;
            // 
            // btnModelo
            // 
            this.btnModelo.Location = new System.Drawing.Point(519, 44);
            this.btnModelo.Name = "btnModelo";
            this.btnModelo.Size = new System.Drawing.Size(75, 20);
            this.btnModelo.TabIndex = 7;
            this.btnModelo.Text = ">";
            this.btnModelo.UseVisualStyleBackColor = true;
            // 
            // btnPreco
            // 
            this.btnPreco.Location = new System.Drawing.Point(519, 21);
            this.btnPreco.Name = "btnPreco";
            this.btnPreco.Size = new System.Drawing.Size(75, 20);
            this.btnPreco.TabIndex = 6;
            this.btnPreco.Text = ">";
            this.btnPreco.UseVisualStyleBackColor = true;
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
            this.lblPreco.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(69, 71);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(430, 21);
            this.cmbFabricante.TabIndex = 2;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(69, 45);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(430, 20);
            this.txtModelo.TabIndex = 1;
            // 
            // nudPrecoMin
            // 
            this.nudPrecoMin.Location = new System.Drawing.Point(69, 19);
            this.nudPrecoMin.Name = "nudPrecoMin";
            this.nudPrecoMin.Size = new System.Drawing.Size(190, 20);
            this.nudPrecoMin.TabIndex = 0;
            // 
            // gboCelulares
            // 
            this.gboCelulares.Controls.Add(this.lstCelular);
            this.gboCelulares.Location = new System.Drawing.Point(12, 142);
            this.gboCelulares.Name = "gboCelulares";
            this.gboCelulares.Size = new System.Drawing.Size(600, 187);
            this.gboCelulares.TabIndex = 0;
            this.gboCelulares.TabStop = false;
            this.gboCelulares.Text = "Celulares";
            this.gboCelulares.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lstCelular
            // 
            this.lstCelular.FormattingEnabled = true;
            this.lstCelular.Location = new System.Drawing.Point(9, 19);
            this.lstCelular.Name = "lstCelular";
            this.lstCelular.Size = new System.Drawing.Size(585, 160);
            this.lstCelular.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 361);
            this.Controls.Add(this.gboCelulares);
            this.Controls.Add(this.gboPesquisa);
            this.Name = "frmPrincipal";
            this.Text = "Lista de Celulares";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.gboPesquisa.ResumeLayout(false);
            this.gboPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoMin)).EndInit();
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
		private System.Windows.Forms.NumericUpDown nudPrecoMin;
		private System.Windows.Forms.ListBox lstCelular;
		private System.Windows.Forms.NumericUpDown nudPrecoMax;
		private System.Windows.Forms.Label lbl4;
	}
}

