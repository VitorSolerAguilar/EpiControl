using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiControl.epicontrol.model
{
    internal class Curso
    {
        public int IdCurso { get; set; }
        public string Nome { get; set; }
        public string CargaHoraria { get; set; }
        public string Descricao { get; set; }
        public int ValidadeMeses { get; set; }
        public string TbCursocol { get; set; }
    }
}
