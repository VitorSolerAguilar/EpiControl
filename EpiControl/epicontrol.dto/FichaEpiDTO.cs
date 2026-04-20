using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiControl.epicontrol.dto
{
	public class FichaEpiDTO
	{
		public int idEmprestimo { get; set; }
		public int idFuncionario { get; set; }   
		public int idEpi { get; set; }				
		public string descricaoEpi { get; set; }  
		public string ca { get; set; }           
		public string codigoInterno { get; set; }  
		public DateTime dataEntrega { get; set; }   
		public int quantidade { get; set; }
	}
}
