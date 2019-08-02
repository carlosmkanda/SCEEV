using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCEEV.Models
{
    public class ClienteJuridico : Cliente, ICnpj
    {
        [Required]
        public string Cnpj { get; set; }

        public ClienteJuridico() { }

        public ClienteJuridico(string nome, string email, DateTime dataNascimento, Endereco endereco, string cnpj)
        {
            this.Cnpj = cnpj;
        }
    }
}
