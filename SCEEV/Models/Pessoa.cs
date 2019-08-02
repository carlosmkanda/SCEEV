using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SCEEV.Models
{
    public abstract class Pessoa : EntityBase
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public IList<Endereco> Enderecos { get; set; }
        public IList<Telefone> Telefones { get; set; }

        public Pessoa() { }

        protected Pessoa(string nome, string email, DateTime dataNascimento)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Enderecos = new List<Endereco>();
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