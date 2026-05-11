using EpiControl.epicontrol.dao;
using EpiControl.epicontrol.views;
using EpiControl.views;
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
            Application.Run(new frmOrcamentoEpi());
        }
    }
}