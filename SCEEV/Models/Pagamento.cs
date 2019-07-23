using System;

namespace SCEEV.Models
{
    public class Pagamento
    {
        public int Id { get; private set; }
        public StatusDePagamento StatusDePagamento { get; private set; }
        public FormaDePagamento FormaDePagamento { get; private set; }
        public int Parcelas {
            get { return Parcelas; }
            private set
            {
                if (value >= 12) throw new Exception("Quantidade de parcelas inválidas");
            }
        }

        public Pagamento(StatusDePagamento statusDePagamento, FormaDePagamento formaDePagamento, int parcelas)
        {
            this.StatusDePagamento = statusDePagamento;
            this.FormaDePagamento = formaDePagamento;
            this.Parcelas = parcelas;
        }
    }
}