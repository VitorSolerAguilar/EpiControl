using EpiControl.epicontrol.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiControl.epicontrol.service
{
	public class FichaEpiService
	{
		public string MontarFicha(List<FichaEpiDTO> lista)
		{
			if (lista.Count == 0)
				return "Nenhum EPI encontrado.";

			string ficha = "FICHA DE ENTREGA DE EPI\n\n";
			ficha += "Funcionário: " + lista[0].Funcionario + "\n\n";

			foreach (var item in lista)
			{
				ficha += $"EPI: {item.Epi}\n";
				ficha += $"CA: {item.CA}\n";
				ficha += $"Quantidade: {item.Quantidade}\n";
				ficha += $"Data: {item.Data.ToShortDateString()}\n";
				ficha += "---------------------------\n";
			}

			ficha += "\nAssinatura:\n_________________________\n";
			ficha += lista[0].Funcionario;

			return ficha;
		}
	}
}
