using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiControl.epicontrol.model
{
	public class Contato
	{
		public int id { get; set; }
		public string telefone { get; set; }
		public string celular { get; set; }
		public string emailPessoal { get; set; }
		public string emailCorporativo { get; set; }

		//FK
		public int funcionarioId { get; set; }
		public int fornecedorId { get; set; }
	}
}
