using CelularCTI.Model.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelularCTI
{
    public partial class frmNovo : Form
    {
		private List<Fabricante> fabricantes;

		public frmNovo()
        {
            InitializeComponent();
        }

        private void frmNovo_Load(object sender, EventArgs e)
        {
			fabricantes = Servico.BuscarFabricante();
			cmbFabricante.DataSource = fabricantes;
			cmbFabricante.DisplayMember = "Nome";
			cmbFabricante.ValueMember = "id_fabricante";
			cmbFabricante.SelectedIndex = -1;
		}

        private void button1_Click(object sender, EventArgs e)
        {
			try
			{
				if (cmbFabricante.SelectedIndex == -1) {

					MessageBox.Show("Selecione o Fabricante ", this.Text,
								MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				Aparelho aparelho = new Aparelho();

				aparelho.Modelo = txtModelo.Text;
				aparelho.Fabricante = fabricantes[cmbFabricante.SelectedIndex];
				aparelho.Largura = Convert.ToDouble(nudLargura.Value);
				aparelho.Altura = Convert.ToDouble(nudAltura.Value);
				aparelho.Espessura = Convert.ToDouble(nudEspessura.Value);
				aparelho.Peso = Convert.ToDouble(nudPeso.Value);
				aparelho.Preco = nudPreco.Value;
				aparelho.Desconto = nudDesconto.Value;

				Servico.Salvar(aparelho);

				MessageBox.Show("O aparelho " + txtModelo.Text + 
								" foi cadastrado com sucesso", this.Text, 
								MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			} catch (ApplicationException ex)
			{

				MessageBox.Show("Ocorreu um ao registrar o aparelho " + txtModelo.Text +
								"\n\nMais detalhes "+ ex.Message, this.Text,
								MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			}
			
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			DialogResult resposta;
			resposta = MessageBox.Show("Você quer realmente cancelar?", this.Text,
								MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (resposta == DialogResult.Yes)
				this.Close();
		}
	}
}
