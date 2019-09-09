using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0909
{
    class Pessoa
    {
        public int Id { get; set; }
        [Required]
        public String Nome { get; set; }
        [Required]
        public String Cpf { get; set; }
        public Endereco Endereco { get; set; }

    }
}
