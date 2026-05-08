using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiControl.epicontrol.model
{
	public class Epi
	{
		public int id { get; set; }
		public string nome { get; set; }
		public string codigoInterno{ get; set; }
		public string ca { get; set; }
		public DateTime validadeCa { get; set; }
		public string status { get; set; }
		public string marca { get; set; }
		public string descricao { get; set; }
		public string categoria { get; set; }
		public string tamanho { get; set; }
		public string cor { get; set; }
        public decimal valorUnitario { get; set; }

        //FK
        public int fornecedorId { get; set; }
	}
}
