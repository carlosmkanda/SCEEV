namespace SCEEV.Models
{
    public class MercadoriaOrcamento
    {
        public int MercadoriaId { get; set; }
        public Mercadoria Mercadoria { get; set; }
        public int OrcamentoId { get; set; }
        public Orcamento Orcamento { get; set; }

        public MercadoriaOrcamento() { }
    }
}