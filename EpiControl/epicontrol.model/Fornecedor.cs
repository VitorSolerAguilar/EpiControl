using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiControl.epicontrol.model
{
	public class Fornecedor
	{
		public int id { get; set; }
		public string nome { get; set; }
		public string cnpj { get; set; }
		public string observacoes { get; set; }
	}
}
