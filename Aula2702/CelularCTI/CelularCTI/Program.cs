using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CelularCTI.Model;
using CelularCTI.Model.Suporte;

namespace CelularCTI
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			CelularCTI.Model.Suporte.ConexaoBanco.Conectar();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmPrincipal());
			CelularCTI.Model.Suporte.ConexaoBanco.Desconectar();
		}
	}
}
