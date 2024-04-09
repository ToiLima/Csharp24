using CelularCTI.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CelularCTI
{
	public partial class frmPrincipal : Form
	{

		private List<Aparelho> aparelhos = new List<Aparelho>();
		private List<Fabricante> fabricantes = new List<Fabricante>();

		public frmPrincipal()
		{
			InitializeComponent();
		}

		private void Frm_Principal_Load(object sender, EventArgs e)
		{
			fabricantes = Servico.BuscarFabricante();
			cmbFabricante.DataSource = fabricantes;
			cmbFabricante.DisplayMember = "Nome";
			cmbFabricante.ValueMember = "id_fabricante";

			aparelhos = Servico.BuscarAparelho();
			lstCelular.DataSource = aparelhos;
		}

		private void btnPreco_Click(object sender, EventArgs e)
		{
			aparelhos = Servico.BuscarAparelho(numPrecoMin.Value, numPrecoMax.Value);
			lstCelular.DataSource = aparelhos;
		}

		private void btnModelo_Click(object sender, EventArgs e)
		{
			aparelhos = Servico.BuscarAparelho(txtModelo.Text);
			lstCelular.DataSource= aparelhos;
		}

		private void btnFabricante_Click(object sender, EventArgs e)
		{
			Fabricante selecionado = fabricantes[cmbFabricante.SelectedIndex];
			aparelhos = Servico.BuscarAparelhos(selecionado);

			Servico.BuscarAparelhos(selecionado);
			lstCelular.DataSource = aparelhos;
		}

		private void btnLstTodos_Click(object sender, EventArgs e)
		{
			aparelhos = Servico.BuscarAparelho();
			lstCelular.DataSource = aparelhos;
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			DialogResult resposta;
			resposta = MessageBox.Show("Você quer sair da aplicação?", this.Text,
								MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (resposta == DialogResult.Yes)
				this.Close();
		}

		private void btnComprar_Click(object sender, EventArgs e)
		{
			Aparelho selecionado = aparelhos[lstCelular.SelectedIndex];
			if (selecionado.Quantidade > 0)
				new frmComprar(selecionado).ShowDialog();
			else
				MessageBox.Show("Não há aparelhos deste modelo no estoque!");

		}

		private void btnNovo_Click(object sender, EventArgs e)
		{
			new frmNovo().ShowDialog();
		}

		private void frmPrincipal_Activated(object sender, EventArgs e)
		{
			aparelhos = Servico.BuscarAparelhos("");
			lstCelular.DataSource = aparelhos;
		}

		private void txtModelo_Click(object sender, EventArgs e)
		{
			aparelhos = Servico.BuscarAparelhos(txtModelo.Text);
			lstCelular.DataSource = aparelhos;
		}		
    }
}
