using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEEV.Models
{
    public class Telefone : EntityBase
    {
        string Ddd { get; set; }
        string Number { get; set; }
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }

        public Telefone() { }
    }
}
