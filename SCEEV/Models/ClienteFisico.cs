using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCEEV.Models
{
    public class ClienteFisico : Cliente, ICpf
    {
        [Required]
        public string Cpf { get; set; }

        public ClienteFisico() { }

        public ClienteFisico(string nome, string email, DateTime dataNascimento, string cpf)
            : base(nome, email, dataNascimento)
        {
            this.Cpf = cpf;
        }


    }
}
