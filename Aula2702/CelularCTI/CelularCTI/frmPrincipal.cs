using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CelularCTI.Model.Entidades;
using CelularCTI.Model;

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

			
			/*foreach (Fabricante fabricante in fabricantes)
				cmbFabricante.Items.Add(fabricante);*/
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void btnModelo_Click(object sender, EventArgs e)
		{
			aparelhos = Servico.BuscarAparelho(txtModelo.Text);
			lstCelular.DataSource= aparelhos;
		}

		private void btnPreco_Click(object sender, EventArgs e)
		{
			aparelhos = Servico.BuscarAparelho(nudPrecoMin.Value, nudPrecoMax.Value);
			lstCelular.DataSource = aparelhos;

		}

		private void btnFabricante_Click(object sender, EventArgs e)
		{
			aparelhos = Servico.BuscarAparelho();
		}
	}
}
