using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEEV.Models
{
    public class ClienteFisico : Cliente, ICpf
    {
        public string Cpf { get; set; }

        public ClienteFisico() { }

        public ClienteFisico(string nome, string email, DateTime dataNascimento, Endereco endereco, string cpf)
            : base(nome, email, dataNascimento, endereco)
        {
            this.Cpf = cpf;
        }


    }
}
