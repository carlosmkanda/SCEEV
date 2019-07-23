using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEEV.Models
{
    public abstract class Pessoa
    {
        public string Nome { get; private set; }
        public string Cpf_Cnpj { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public IList<string> Telefones { get; private set; }
        public string Email { get; private set; }
        public Endereco Endereco { get; private set; }
        public IList<Venda> Historico { get; private set; }

        public Pessoa(string nome, string cpf_cnpj, DateTime dataNascimento, IList<string> telefones, string email, Endereco endereco)
        {
            this.Nome = nome;
            this.Cpf_Cnpj = cpf_cnpj;
            this.DataNascimento = dataNascimento;
            this.Email = email;
            this.Endereco = endereco;
            this.Historico = new List<Venda>();
            this.Telefones = new List<string>();
            foreach (string telefone in telefones)
            {
                this.Telefones.Add(telefone);
            }
        }
        public void AdicionaCompras(IList<Venda> vendas)
        {
            foreach (Venda venda in vendas)
            {
                Historico.Add(venda);
            }
        }

        public void RemoveCompras(IList<Venda> vendas)
        {
            foreach (Venda venda in vendas)
            {
                Historico.Remove(venda);
            }
        }
    }
}
