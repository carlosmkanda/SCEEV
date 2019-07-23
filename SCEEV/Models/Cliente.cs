using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEEV.Models
{
    public class Cliente : Pessoa
    {
        public int Id { get; private set; }

        private static int id = 1;

        Cliente(string nome, string cpf_cnpj, DateTime dataNascimento, IList<string> telefones, string email, Endereco endereco) 
            : base(nome, cpf_cnpj, dataNascimento, telefones, email, endereco)
        {
            this.Id = id++;
        }
    }
}
