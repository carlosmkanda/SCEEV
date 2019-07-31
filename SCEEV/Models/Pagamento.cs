using System;

namespace SCEEV.Models
{
    public class Pagamento : EntityBase
    {
        public StatusDePagamento StatusDePagamento { get; set; }
        public FormaDePagamento FormaDePagamento { get; set; }
        public int Parcelas {
            get { return Parcelas; }
            set
            {
                if (value >= 12 || value < 1) throw new Exception("Quantidade de parcelas inválidas");
            }
        }
        public int VendaId { get; set; }
        public Venda Venda { get; set; }

        public Pagamento() { }

        public Pagamento(StatusDePagamento statusDePagamento, FormaDePagamento formaDePagamento, int parcelas, Venda venda)
        {
            this.StatusDePagamento = statusDePagamento;
            this.FormaDePagamento = formaDePagamento;
            this.Parcelas = parcelas;
            this.Venda = venda;
        }
    }
}