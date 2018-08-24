using DesignPaterns.ChainOfResponsability.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPaterns.State
{
    public interface IEstadoConta
    {
        void Saca(double valor, Conta conta);
        void Deposita(double valor, Conta conta);

        void NegativaConta(Conta conta);
        void PositivaConta(Conta conta);

        

    }

    public class ContaPositiva : IEstadoConta
    {
        public void Deposita(double valor, Conta conta)
        {
            double valorDeposito = valor * 0.98;
            conta.ValorConta += valorDeposito;
            if (ContaEstaNegativa(conta))
                this.NegativaConta(conta);
           
        }

        private bool ContaEstaNegativa(Conta conta)
        {
            if (conta.ValorConta < 0)
                return true;
            else
                return false;
        }

        public void Saca(double valor, Conta conta)
        {
            conta.ValorConta -= valor;
            if (ContaEstaNegativa(conta))
                this.NegativaConta(conta);
        }

        public void NegativaConta(Conta conta)
        {
            conta.estadoConta = new ContaNegativa();
        }

        public void PositivaConta(Conta conta)
        {
            throw new Exception("Conta já está positiva");
        }

        
    }


    public class ContaNegativa : IEstadoConta
    {
        public void Deposita(double valor, Conta conta)
        {
            double valorDeposito = valor * 0.95;
            conta.ValorConta += valorDeposito;
            if (!this.ContaEstaNegativa(conta))
                    this.PositivaConta(conta);

        }

        private bool ContaEstaNegativa(Conta conta)
        {
            if (conta.ValorConta < 0)
                return true;
            else
                return false;
        }

        public void NegativaConta(Conta conta)
        {
            throw new Exception("Conta já se encontra negativa");
        }

        public void PositivaConta(Conta conta)
        {
            conta.estadoConta = new ContaPositiva();
        }

        public void Saca(double valor, Conta conta)
        {

            throw new Exception("Sua conta está negativa "+conta.ValorConta.ToString("N2")+", não é possivel efetuar o saque.");
        }
    }
}
