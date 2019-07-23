namespace SCEEV.Models
{
    public class Endereco
    {
        public int Id { get; private set; }
        public string CEP { get; private set; }
        public string Estado { get; private set; }
        public string Municipio { get; private set; }
        public string Bairro { get; private set; }
        public string Logradouro { get; private set; }
        public int Numero { get; private set; }
        public string Complemento { get; private set; }

        private static int id = 1;

        public Endereco(string cep, string estado, string municipio, string bairro, string logradouro, int numero)
        {
            this.Id = id++;
            this.CEP = cep;
            this.Estado = estado;
            this.Municipio = municipio;
            this.Bairro = bairro;
            this.Logradouro = logradouro;
            this.Numero = numero;
        }
        public Endereco(string cep, string estado, string municipio, string bairro, string logradouro, int numero, string complemento)
        {
            this.Id = id++;
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