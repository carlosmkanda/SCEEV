using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEEV.Models
{
    public class Mercadoria : EntityBase
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int QuantidadeEstoque { get; set; }
        public string Descricao { get; set; }
        public IList<MercadoriaOrcamento> MercadoriaOrcamentos { get; set; }

        public Mercadoria () { }

        public Mercadoria(string nome, double valor, int quantidadeEstoque, string descricao)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.QuantidadeEstoque = quantidadeEstoque;
            this.Descricao = descricao;
            this.MercadoriaOrcamentos = new List<MercadoriaOrcamento>();
        }
    }
}
