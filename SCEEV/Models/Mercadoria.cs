using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEEV.Models
{
    public class Mercadoria
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Valor { get; private set; }
        public int QuantidadeEstoque { get; private set; }
        public string Descricao { get; private set; }

        private static int id = 1;

        public Mercadoria(string nome, double valor, int quantidadeEstoque, string descricao)
        {
            this.Id = id++;
            this.Nome = nome;
            this.Valor = valor;
            this.QuantidadeEstoque = quantidadeEstoque;
            this.Descricao = descricao;
        }
    }
}
