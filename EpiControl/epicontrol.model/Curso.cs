using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiControl.epicontrol.model
{
    public class Curso
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cargaHoraria { get; set; }
        public string descricao { get; set; }
        public DateTime dataValidade { get; set; } 
        public int validadeMeses { get; set; }
    }
}
