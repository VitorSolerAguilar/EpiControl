using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiControl.epicontrol.model
{
	public  class EstoqueEpi
	{
		public int id { get; set; }
		public int quantidade { get; set; }
		public string localizacao { get; set; }
		public int? estoqueMinimo { get; set; }

		//FK	
		public int epiId { get; set; }
	}
}
