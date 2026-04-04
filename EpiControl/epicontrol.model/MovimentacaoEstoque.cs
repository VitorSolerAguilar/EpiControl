using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiControl.epicontrol.model
{
	public class MovimentacaoEstoque
	{
		public int id { get; set; }
		public string tipoMovimentacao { get; set; }
		public int quantidade { get; set; }
		public DateTime dataMovimentacao { get; set; }
		public string observacao { get; set; }

		//FK
		public int estoqueId { get; set; }
		public int funcionarioId { get; set; }
	}
}
