using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiControl.epicontrol.model
{
	public class Endereco
	{
		public int id { get; set; }
		public string cep { get; set; }
		public string cidade { get; set; }
		public string uf { get; set; }
		public string rua { get; set; }
		public string numero { get; set; }
		public string logradouro { get; set; }
		public string tipo { get; set; }
		public string complemento { get; set; }

		//FK
		public int funcionarioId { get; set; }
		public int fornecedorId { get; set; }
	}
}
