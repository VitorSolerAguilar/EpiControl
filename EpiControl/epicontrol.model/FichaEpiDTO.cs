using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiControl.epicontrol.model
{
	public class FichaEpiDTO
	{
		public string Funcionario { get; set; }
		public string Epi { get; set; }
		public string CA { get; set; }
		public int Quantidade { get; set; }
		public DateTime Data { get; set; }
	}
}
