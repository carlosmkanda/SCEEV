using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEEV.Models
{
    public class Orcamento : EntityBase
    {
        public double Valor { get; set; }
        public int ResponsavelId { get; set; }
        public Usuario Responsavel { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public Venda Venda { get; set; }
        public IList<MercadoriaOrcamento> MercadoriasOrcamentos { get; set; }


        public Orcamento() { }

        public Orcamento(double valor, Cliente cliente, Usuario responsavel, Venda venda)
        {
            this.Valor = valor;
            this.Cliente = cliente;
            this.Responsavel = responsavel;
            this.Venda = venda;
            this.MercadoriasOrcamentos = new List<MercadoriaOrcamento>();
        }
    }
}
