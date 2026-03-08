using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiControl.epicontrol.model
{
	public class NormaRegulamentadora
	{
		public int id { get; set; }
		public string codigoNr { get; set; }
		public string titulo { get; set; }
		public string descricao { get; set; }
		public string linkMte { get; set; }
		public DateTime dataVigencia { get; set; }
	}
}
