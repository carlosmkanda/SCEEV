using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEEV.Models
{
    public class Usuario : Pessoa
    {
        public int Id { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public double Salario { get; private set; }
        public double Comissao { get; private set; }

        public static int id = 1;

        public Usuario(string nome, string cpf_cnpj, DateTime dataNascimento, IList<string> telefones, string email, Endereco endereco, string login, string password, double salario, double comissao)
            :base(nome, cpf_cnpj, dataNascimento, telefones, email, endereco)
        {
            this.Id = id++;
            this.Login = login;
            this.Password = password;
            this.Salario = salario;
            this.Comissao = comissao;
        }
    }
}
