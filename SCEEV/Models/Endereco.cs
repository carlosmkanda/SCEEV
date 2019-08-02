using System.ComponentModel.DataAnnotations;

namespace SCEEV.Models
{
    public class Endereco : EntityBase
    {
        [Required]
        public string CEP { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public string Municipio { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string Logradouro { get; set; }
        [Required]
        public int Numero { get; set; }
        public string Complemento { get; set; }

        public Endereco() { }

        public Endereco(string cep, string estado, string municipio, string bairro, string logradouro, int numero)
        {
            this.CEP = cep;
            this.Estado = estado;
            this.Municipio = municipio;
            this.Bairro = bairro;
            this.Logradouro = logradouro;
            this.Numero = numero;
        }
        public Endereco(string cep, string estado, string municipio, string bairro, string logradouro, int numero, string complemento)
        {
            this.CEP = cep;
            this.Estado = estado;
            this.Municipio = municipio;
            this.Bairro = bairro;
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Complemento = complemento;
        }
    }
}