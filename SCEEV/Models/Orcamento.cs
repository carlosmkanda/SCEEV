using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCEEV.Models
{
    public class Orcamento : EntityBase
    {
        [Required]
        public double Valor { get; set; }
        [Required]
        public Usuario Responsavel { get; set; }
        public Cliente Cliente { get; set; }
        public IList<MercadoriaOrcamento> MercadoriasOrcamentos { get; set; }


        public Orcamento() { }

        public Orcamento(double valor, Cliente cliente, Usuario responsavel, Venda venda)
        {
            this.Valor = valor;
            this.Cliente = cliente;
            this.Responsavel = responsavel;
            this.MercadoriasOrcamentos = new List<MercadoriaOrcamento>();
        }
    }
}
