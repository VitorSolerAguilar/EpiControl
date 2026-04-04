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
        public string inicio { get; set; }
        public string conclusao { get; set; }
        public int validadeMeses { get; set; }
        public int fk_funcionario { get; set; }
        public int fk_curso { get; set; }
    }
}
