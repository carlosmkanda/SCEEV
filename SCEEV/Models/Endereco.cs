namespace SCEEV.Models
{
    public class Endereco : EntityBase
    {
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }

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