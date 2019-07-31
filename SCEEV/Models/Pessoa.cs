using System;
using System.Collections.Generic;

namespace SCEEV.Models
{
    public abstract class Pessoa : EntityBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
        public IList<Telefone> Telefones { get; set; }

        public Pessoa() { }

        protected Pessoa(string nome, string email, DateTime dataNascimento, Endereco endereco)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Telefones = new List<Telefone>();
        }

        public void AdicionaTelefones(IList<Telefone> telefones)
        {
            foreach (Telefone telefone in telefones)
            {
                Telefones.Add(telefone);
            }
        }

        public void RemoveTelefones(IList<Telefone> telefones)
        {
            foreach (Telefone telefone in telefones)
            {
                Telefones.Remove(telefone);
            }
        }
    }
}