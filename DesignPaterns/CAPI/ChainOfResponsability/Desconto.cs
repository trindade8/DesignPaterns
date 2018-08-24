using DesignPaterns.Stratedy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPaterns.ChainOfResponsability
{
    public abstract class Desconto : IDesconta
    {
        public IDesconta next { get; set; }
        public static string Nome { get; set; }

        public abstract double Desconta(Orcamento orc);

        public virtual void SetNext(IDesconta desconta)
        {
            this.next = desconta;
        }

        public Desconto()
        {
            this.next = new SemDesconto();
        }
    }

    public class DescontoMaisCincoItens : Desconto
    {

        public override double Desconta(Orcamento orc)
        {

            if (orc.CountItens() > 5)
            {
                double valorDeconto = orc.Valor * 0.10;
                Desconto.Nome = "DescontoMaisCincoItens";
                return valorDeconto;
            }
            else
                return this.next.Desconta(orc);

        }
    }

    public class DescontoValorMaiorQuientos : Desconto
    {
        public override double Desconta(Orcamento orc)
        {
            if (orc.Valor > 500)
            {
                Desconto.Nome = "DescontoValorMaiorQuientos";
                return orc.Valor * 0.07;
            }
                
            else
                return this.next.Desconta(orc);
        }
    }

    public class SemDesconto : IDesconta
    {
        public  double Desconta(Orcamento orc)
        {
            Desconto.Nome = "SemDesconto";
            return 0; 
        }
    }

    public class DescontoCasado : Desconto
    {
        public override double Desconta(Orcamento orc)
        {
            bool hasLapis = this.hasItem(orc, "lapis");
            bool hasCaneta = this.hasItem(orc, "caneta");
            if (hasLapis.Equals(hasCaneta))
            {
                Desconto.Nome = "Desconto Casado";
                return orc.Valor * 0.07;
            }
            else
                return this.next.Desconta(orc);
        }

        private bool hasItem(Orcamento orc, string nome_item)
        {
            nome_item = nome_item.ToUpper();
            foreach(Item i in orc.Itens)
            {
                if (i.Nome.ToUpper().Equals(nome_item))
                    return true;
            }
            return false;
        }
    }

    public class CalculadoraDesconto
    {
        private Orcamento orcamento { set; get; }
        public Desconto desconto { get; set; }
        public CalculadoraDesconto(Orcamento orc, Desconto desc)
        {

        }

        public CalculadoraDesconto(Orcamento orcamento)
        {
            this.orcamento = orcamento;
            SemDesconto semDesconto = new SemDesconto();
            DescontoMaisCincoItens cincoItens = new DescontoMaisCincoItens();
            DescontoCasado descontoCasado = new DescontoCasado();
            DescontoValorMaiorQuientos descontoquientosReais = new DescontoValorMaiorQuientos();
            cincoItens.SetNext(descontoCasado);
            descontoCasado.SetNext(descontoquientosReais);
            descontoquientosReais.SetNext(semDesconto);
            this.desconto = cincoItens;
        }

        public double AplicaDesconto()
        {
            return this.desconto.Desconta(this.orcamento);
        }
    }
}

