using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPaterns.ChainOfResponsability.Conta
{
   public class Banco
    {

        public void SetContas(List<Conta> contas)
        {
            this.Contas = contas;
        }
        public Banco(string nome, string endereco, string telefone, string email)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            this.Contas = new List<Conta>();
        }

        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public List<Conta> Contas { get; set; }


    }
}
