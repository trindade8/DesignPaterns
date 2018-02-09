using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPaterns.Stratedy
{
    public class CalculadorDeImposto
    {
        private Orcamento orcamento { get; set; }
        private Imposto imposto { get; set; }
        public CalculadorDeImposto(Orcamento orc, Imposto imposto)
        {
            this.orcamento = orc;
            this.imposto = imposto;   

        }

        public Double CalculaImposto()
        {
            return this.imposto.Calcula(this.orcamento);
        }
    }
}
