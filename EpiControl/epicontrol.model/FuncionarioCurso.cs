using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiControl.epicontrol.model
{
    public class FuncionarioCurso
    {
        public int id { get; set; }
        public DateTime inicio { get; set; }
        public DateTime? conclusao { get; set; }

        //FK
		public int funcionarioId { get; set; }
        public int cursoId { get; set; }
    }
}
