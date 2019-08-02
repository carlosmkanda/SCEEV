using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCEEV.Models
{
    public class Telefone : EntityBase
    {
        [Required]
        public string Numero { get; set; }

        public Telefone() { }

        public Telefone(string numero)
        {
            this.Numero = numero;
        }
    }
}
