using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0909
{
    class Cargo
    {
        public int Id { get; set; }
        public String NomeCargo { get; set; }
        public Double SalarioBase { get; set; }
        public String Atribuicao { get; set; }
        public IList<Departamento> Departamentos { get; set; }
    }
}
