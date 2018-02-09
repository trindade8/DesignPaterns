using DesignPaterns.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPaterns.ChainOfResponsability.Conta
{
    public class Conta
    {
        public string NomeTitular { get; set; }
        public double ValorConta { get; set; }
        public String Agencia { get; set; }
        public String NumeroConta { get; set; }
        public DateTime DataAbertura { get; set; }
        public IEstadoConta estadoConta { get; set; }

        #region Construtores
        public Conta() { }
        public Conta(string nome, double valor)
        { this.NomeTitular = nome; this.ValorConta = valor; this.estadoConta = new ContaPositiva(); }
            
        public Conta(string nomeTitular, double valorConta, string agencia, string numeroConta): this(nomeTitular,valorConta)
        {
            Agencia = agencia;
            NumeroConta = numeroConta;
            DataAbertura = DateTime.Now;
        }

        #endregion

        public void Deposita(double valorDeposito)
        {
            this.estadoConta.Deposita(valorDeposito, this);
        }

        public void Saca(double valorSaque)
        {
            this.estadoConta.Saca(valorSaque, this);
        }


    }
}
