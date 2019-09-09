using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0909
{
    class Lotacao
    {
        public int Id { get; set; }
        public decimal Salario { get; set; }
        [Required]
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        [Required]
        public Cargo cargo { get; set; }
        [Required]
        public Departamento Departamento { get; set; }
    }
}
