using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0909
{
    class Funcionario : Pessoa
    {
        public IList<Lotacao> Lotacaos { get; set; }
        public DateTime Admissao { get; set; }
        public DateTime Demissao { get; set; }
    }
}
