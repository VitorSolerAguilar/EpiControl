using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiControl.epicontrol.dto
{
    public class RelatorioEpiDTO
    {
        public int idEpi { get; set; }
        public string nomeEpi { get; set; }
        public string codigoInterno { get; set; }
        public string ca { get; set; }

        public int totalQuantidade { get; set; }      
        public int totalEmprestimos { get; set; }   

        public DateTime? primeiraEntrega { get; set; }
        public DateTime? ultimaEntrega { get; set; }
    }
}
