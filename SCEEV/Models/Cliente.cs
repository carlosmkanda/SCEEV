using System;
using System.Collections.Generic;

namespace SCEEV.Models
{
    public abstract class Cliente : Pessoa
    {
        public IList<Venda> Compras { get; set; }
        public IList<Orcamento> Orcamentos { get; set; }

        public Cliente() { }

        public Cliente(string nome, string email, DateTime dataNascimento, Endereco endereco)
            : base(nome, email, dataNascimento, endereco)
        {
            this.Compras = new List<Venda>();
            this.Orcamentos = new List<Orcamento>();
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

        public void AdicionaCompras(IList<Venda> compras)
        {
            foreach (Venda compra in compras)
            {
                Compras.Add(compra);
            }
        }

        public void RemoveCompras(IList<Venda> compras)
        {
            foreach (Venda compra in compras)
            {
                Compras.Remove(compra);
            }
        }
    }
}