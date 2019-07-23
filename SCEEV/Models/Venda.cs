using System;
using System.Collections.Generic;

namespace SCEEV.Models
{
    public class Venda
    {
        public int Id { get; private set; }
        public Orcamento Orcamento { get; private set; }
        public DateTime DataRealizacao { get; private set; }
        public Pagamento Pagamento { get; private set; }

        private static int id = 1;

        public Venda(DateTime dataRealizacao, Orcamento orcamento, FormaDePagamento formaDePagamento, int parcelas)
        {
            this.Id = id++;
            this.DataRealizacao = dataRealizacao;
            this.Orcamento = orcamento;
            this.Pagamento = new Pagamento(StatusDePagamento.PENDENTE, formaDePagamento, parcelas);
        }

        public Venda(DateTime dataRealizacao, Orcamento orcamento, Pagamento pagamento)
        {
            this.Id = id++;
            this.DataRealizacao = dataRealizacao;
            this.Orcamento = orcamento;
            this.Pagamento = pagamento;
        }

        public Venda(DateTime dataRealizacao, Orcamento orcamento, StatusDePagamento statusPagamento, FormaDePagamento formaDePagamento, int parcelas)
        {
            this.Id = id++;
            this.DataRealizacao = dataRealizacao;
            this.Orcamento = orcamento;
            this.Pagamento = new Pagamento(statusPagamento, formaDePagamento, parcelas);
        }

        public Venda(DateTime dataRealizacao, Usuario responsavel, Cliente cliente, double valor, IList<Mercadoria> mercadorias, FormaDePagamento formaDePagamento, int parcelas)
            : this(dataRealizacao, new Orcamento(responsavel, cliente, valor, mercadorias), formaDePagamento, parcelas) { }
               
        public Venda(DateTime dataRealizacao, Usuario responsavel, Cliente cliente, double valor, IList<Mercadoria> mercadorias, Pagamento pagamento)
            : this(dataRealizacao, new Orcamento(responsavel, cliente, valor, mercadorias), pagamento) { }
    }
}