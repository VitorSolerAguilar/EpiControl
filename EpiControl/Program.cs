using EpiControl.epicontrol.views;
using EpiControl.Views.Emprestimo;
using EpiControl.Views.EPI;
using EpiControl.Views.Fornecedores;
using EpiControl.Views.Funcionario;
using EpiControl.Views.Norma_Regulamentadora;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace EpiControl
{
    internal static class Program
    {
		public static IConfiguration Configuration { get; private set; }

		[STAThread]
        static void Main()
        {
			Configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
			.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
			.Build();

			ApplicationConfiguration.Initialize();
            Application.Run(new CadastrarFornecedor());
        }
    }
}