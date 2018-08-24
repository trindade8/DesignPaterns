using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPaterns.Stratedy.Investimentos
{
    public abstract class Investimento
    {
        public double ValorInvestido { get; set; }

    }


    public class Conservador : Investimento, IInvestimento
    {


        public double Calcula(double valor)
        {
            return valor * 0.08;
        }
    }

    public class Moderado : Investimento, IInvestimento
    {

        public bool maiorIvestimento { get; private set; }

        public double Calcula(double valor)
        {
            int i = new Random().Next(2) ;
            this.maiorIvestimento = i>=1;
            if (this.maiorIvestimento)
                return valor * 0.07;
            else
                return valor * 0.025;

        }

        public String txtInvestimento()
        {
            if (maiorIvestimento)
                return "Maior Investimento";
            return "Menor Investimento";
        }
    }

    public class Arrojado : Investimento, IInvestimento
    {
        public String LucroRetorno { get; set; }

        public double Calcula(double valor)
        {
            return valor * this.criaPorcentagemInvestimento();

        }

        private double criaPorcentagemInvestimento()
        {
            int range = new Random().Next(1, 10);
            if (range > 1 && range <= 2)
            {
                this.LucroRetorno = "20%";
                return 0.05;
            }
            else if (range >= 3 && range <= 5)
            {
                this.LucroRetorno = "30%";
                return 0.03;
            }
            else
            {
                this.LucroRetorno = "50%";
                return 0.006;
            }

        }
    }

    public class CalculadoraInvestimento
    {
        private double ValorInvestido { get; set; }
        private IInvestimento Investimento { get; set; }
        public CalculadoraInvestimento(double valorInvestido, IInvestimento investimento)
        {
            this.ValorInvestido = valorInvestido;
            this.Investimento = investimento; 
        }

        public double CalculaLucro()
        {
            return this.Investimento.Calcula(this.ValorInvestido);
        }



    }


}
