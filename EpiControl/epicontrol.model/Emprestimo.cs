using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiControl.epicontrol.model
{
	public class Emprestimo
	{
		public int id { get; set; }
		public int quantidade { get; set; }
		public DateTime dataEntrega { get; set; }
		public string observacoes { get; set; }

		//FK
		public int funcionarioId { get; set; }
		public int epiId { get; set; }
	}
}
