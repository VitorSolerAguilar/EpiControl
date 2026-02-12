using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiControl.epicontrol.model
{
	public class Funcionario
	{
		public int id { get; set; }
		public string nome { get; set; }
		public string rg { get; set; }
		public string cpf { get; set; }
		public string pis { get; set; }
		public DateTime dataNascimento { get; set; }
		public string numeroCTPS { get; set; }
		public string serieCtps { get; set; }
		public string estadoCivil { get; set; }
		public string genero { get; set; }
		public string nomeMae { get; set; }
		public string nomePai { get; set; }
		public string inscricaoETitulo { get; set; }
		public string zona { get; set; }
		public string secao { get; set; }
		public string municipio { get; set; }
		public string uf { get; set; }
		public DateTime dataEmissao { get; set; }
	}
}
