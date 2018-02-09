using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPaterns.Stratedy;

namespace DesignPaterns.Chain_of_responsibility
{
    public abstract class Desconto : IDesconto
    {

        protected IDesconto next { get; set; }
        public Desconto()
        {
            this.next = new SemDesconto();
        }

        public void SetNext(IDesconto idesconto)
        {
            this.next = idesconto;
        }
        public abstract double Calcula(Orcamento orc);


    }

    public class SemDesconto : Desconto
    {
        public override double Calcula(Orcamento orc)
        {
            return 0;
        }
    }


    public class DescontoPorMaisDeQuinhentosReais : Desconto
    {
        public override double Calcula(Orcamento orc)
        {
            if (orc.Valor > 500)
                return   orc.Valor * 0.07;

                return this.next.Calcula(orc);
        }
    }

    public class DescontoPorVendaCasada : Desconto
    {


        public override double Calcula(Orcamento orc)
        {
            bool hasLapis = hasItem(orc, "lapis");
            bool hasCaneta = hasItem(orc, "caneta");
            if (hasLapis.Equals(hasCaneta))
                return orc.Valor * 0.05;
            else
                return this.next.Calcula(orc);
        }

        private bool hasItem(Orcamento orc, string word)
        {
            word = word.ToUpper();
            foreach (Item i in orc.Itens)
            {
                if (i.Descricao.ToUpper().Equals(word))
                    return true;
            }
            return false;
        }


    }




}
