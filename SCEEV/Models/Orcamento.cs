using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEEV.Models
{
    public class Orcamento
    {
        public int Id { get; private set; }
        public Usuario Responsavel { get; private set; }
        public Cliente Cliente { get; private set; }
        public IList<Mercadoria> Mercadorias { get; private set; }
        public double Valor { get; private set; }

        private static int id = 1;

        public Orcamento(Usuario responsavel, Cliente cliente, double valor)
        {
            this.Id = id++;
            this.Responsavel = responsavel;
            this.Cliente = cliente;
            this.Valor = valor;
            this.Mercadorias = new List<Mercadoria>();
        }

        public Orcamento(Usuario responsavel, Cliente cliente, double valor, IList<Mercadoria> mercadorias)
        {
            this.Id = id++;
            this.Responsavel = responsavel;
            this.Cliente = cliente;
            this.Valor = valor;
            this.Mercadorias = new List<Mercadoria>();
            AdicionaMercadorias(mercadorias);
        }

        public void AdicionaMercadorias(IList<Mercadoria> mercadorias)
        {
            foreach (Mercadoria mercadoria in mercadorias)
            {
                Mercadorias.Add(mercadoria);
            }
        }

        public void RemoveMercadorias(IList<Mercadoria> mercadorias)
        {
            foreach (Mercadoria mercadoria in mercadorias)
            {
                Mercadorias.Remove(mercadoria);
            }
        }
    }
}
