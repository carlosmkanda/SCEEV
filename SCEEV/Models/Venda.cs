using System;
using System.Collections.Generic;

namespace SCEEV.Models
{
    public class Venda : EntityBase
    {
        public DateTime DataRealizacao { get; set; }
        public int OrcamentoId { get; set; }
        public Orcamento Orcamento { get; set; }
        public Pagamento Pagamento { get; set; }
        public int ResponsavelId { get; set; }
        public Usuario Responsavel { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public Venda() { }

        public Venda(DateTime dataRealizacao, Orcamento orcamento, FormaDePagamento formaDePagamento, int parcelas, Usuario responsavel, Cliente cliente)
        {
            this.DataRealizacao = dataRealizacao;
            this.Orcamento = orcamento;
            this.Pagamento = new Pagamento(StatusDePagamento.PENDENTE, formaDePagamento, parcelas, this);
            this.Responsavel = responsavel;
            this.Cliente = cliente;
        }

        public Venda(DateTime dataRealizacao, Orcamento orcamento, Pagamento pagamento, Usuario responsavel, Cliente cliente)
        {
            this.DataRealizacao = dataRealizacao;
            this.Orcamento = orcamento;
            this.Pagamento = pagamento;
            this.Responsavel = responsavel;
            this.Cliente = cliente;
        }

        public Venda(DateTime dataRealizacao, Orcamento orcamento, StatusDePagamento statusPagamento, FormaDePagamento formaDePagamento, int parcelas, Usuario responsavel, Cliente cliente)
        {
            this.DataRealizacao = dataRealizacao;
            this.Orcamento = orcamento;
            this.Pagamento = new Pagamento(statusPagamento, formaDePagamento, parcelas, this);
            this.Responsavel = responsavel;
            this.Cliente = cliente;
        }
    }
}