using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCEEV.Models
{
    public class Usuario : Pessoa, ICpf
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public double Salario { get; set; }
        [Required]
        public double Comissao { get; set; }
        [Required]
        public string Cpf { get; set; }
        public IList<Orcamento> Orcamentos { get; set; }
        public IList<Venda> Vendas { get; set; }

        public Usuario() { }

        public Usuario(string nome, string email, DateTime dataNascimento, string login, string senha, double salario, double comissao, string cpf)
            : base(nome, email, dataNascimento)
        {
            this.Login = login;
            this.Senha = senha;
            this.Salario = salario;
            this.Comissao = comissao;
            this.Cpf = cpf;
            this.Orcamentos = new List<Orcamento>();
            this.Vendas = new List<Venda>();
        }

        public void AdicionaOrcamentos(IList<Orcamento> orcamentos)
        {
            foreach (Orcamento orcamento in orcamentos)
            {
                Orcamentos.Add(orcamento);
            }
        }

        public void RemoveOrcamentos(IList<Orcamento> orcamentos)
        {
            foreach (Orcamento orcamento in orcamentos)
            {
                Orcamentos.Remove(orcamento);
            }
        }

        public void AdicionaVendas(IList<Venda> vendas)
        {
            foreach (Venda venda in vendas)
            {
                Vendas.Add(venda);
            }
        }

        public void RemoveVendas(IList<Venda> vendas)
        {
            foreach (Venda venda in vendas)
            {
                Vendas.Remove(venda);
            }
        }
    }
}
