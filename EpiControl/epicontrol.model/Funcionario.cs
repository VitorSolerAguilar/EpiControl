using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EpiControl.epicontrol.model
{
	public class Funcionario
	{
		public int id { get; set; }
		public string nome { get; set; }
		public DateTime dataNascimento { get; set; }
		public string estadoCivil { get; set; }
		public string nacionalidade { get; set; }
		public string genero { get; set; }
		public string nomeMae { get; set; }
		public string nomePai { get; set; }
		public string tituloEleitor { get; set; }
		public string pisPasep { get; set; }
		public string rg { get; set; }
		public string cpf { get; set; }		
		public string matricula { get; set; }
		public string cargo { get; set; }
		public string status { get; set; }

	}
}
