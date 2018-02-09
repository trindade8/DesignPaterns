using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPaterns.Stratedy

{
    #region Classes Abstratas

    public abstract class Imposto
    {
        public double aliquota { get; set; }
        public Imposto OutroImposto { get; set; }


        public Imposto(Imposto outro_imposto)
        {
            this.OutroImposto = outro_imposto;
        }


        public Imposto()
        {
            this.OutroImposto = null;
        }

        protected double CalculoOutroImposto(Orcamento orc)
        {
            if (this.OutroImposto != null)
                return this.OutroImposto.Calcula(orc);
            else
                return 0;
        }

        protected double CalculoOutroImposto(double valor)
        {
            if (this.OutroImposto != null)
                return this.OutroImposto.Calcula(valor);
            else
                return 0;
        }

        public abstract double Calcula(Orcamento orc);
        public abstract double Calcula(double valor);

    }

    public abstract class TemplateImpostoCondicional : Imposto
    {


        public TemplateImpostoCondicional() : base()
        {
        }

        public TemplateImpostoCondicional(Imposto outro_imposto) : base(outro_imposto)
        {

        }

        public override double Calcula(Orcamento orc)
        {
            if (DeveUsarMaximaTaxacao(orc))
                return MaximaTaxacao(orc) + this.CalculoOutroImposto(orc);
            else
                return MinimaTaxacao(orc) + this.CalculoOutroImposto(orc);
        }

        public override double Calcula(double valor)
        {
            if (DeveUsarMaximaTaxacao(valor))
                return MaximaTaxacao(valor) + this.CalculoOutroImposto(valor);
            else
                return MinimaTaxacao(valor) + this.CalculoOutroImposto(valor);
        }

        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orc);
        protected abstract double MaximaTaxacao(Orcamento orc);
        protected abstract double MinimaTaxacao(Orcamento orc);

        protected abstract bool DeveUsarMaximaTaxacao(double valor);
        protected abstract double MaximaTaxacao(double valor);
        protected abstract double MinimaTaxacao(double valor);

    }

    #endregion

    #region  ICMS
    public class ICMS : Imposto
    {


        public ICMS() : base() 
        {
            this.aliquota = 5;
        }

        public ICMS(Imposto outro_imposto) : base(outro_imposto)
        {
            this.aliquota = 5;
        }



        public override double Calcula(Orcamento orc)
        {
            if (this.aliquota > 0)
                return (orc.Valor * (this.aliquota / 100)) + this.CalculoOutroImposto(orc);
            else
                return 0;
        }

        public override double Calcula(double valor)
        {
            if (this.aliquota > 0)
                return (valor * (this.aliquota / 100)) + this.CalculoOutroImposto(valor);
            else
                return 0;
        }
    }
    #endregion

    #region ISS
    public class ISS : Imposto
    {
        public ISS() : base()
        {
            this.aliquota = 6;
        }

        public ISS(Imposto outro_imposto) : base(outro_imposto)
        {
            this.aliquota = 6;
        }

        public override double Calcula(double valor)
        {
            if (this.aliquota > 0)
                return ((valor * (this.aliquota / 100)) + 50) + this.CalculoOutroImposto(valor);
            else
                return 0;
        }

        public override double Calcula(Orcamento orc)
        {
            if (this.aliquota > 0)
                return  ( (orc.Valor * (this.aliquota / 100)) + 50) + this.CalculoOutroImposto(orc); 
            else
                return 0;
        }
    }
    #endregion

    #region ICCC 
    public class ICCC : Imposto
    {

        
        public ICCC(Imposto outro_imposto) : base(outro_imposto)
        {
            this.aliquota = 5;
        }

        public ICCC() : base()
        {
            this.aliquota = 5;
        }

        public override Double Calcula(Orcamento orc)
        {
            if (orc.Valor > 3000)
            {
                this.aliquota = 8;
                return ((orc.Valor * (this.aliquota / 100)) + 30)+this.CalculoOutroImposto(orc);
            }
            else if (orc.Valor >= 1000 && orc.Valor <= 3000)
            {
                this.aliquota = 7;
            }
            return ((orc.Valor * (this.aliquota / 100)))+this.CalculoOutroImposto(orc);

        }


        public override Double Calcula(double valor)
        {
            if (valor > 3000)
            {
                this.aliquota = 8;
                return ((valor * (this.aliquota / 100)) + 30) + this.CalculoOutroImposto(valor);
            }
            else if (valor >= 1000 && valor <= 3000)
            {
                this.aliquota = 7;
            }
            return ((valor * (this.aliquota / 100))) + this.CalculoOutroImposto(valor);

        }
    }
    #endregion 

    #region ICPP
    public class ICPP : TemplateImpostoCondicional
    {

        public ICPP() : base() { }
        public ICPP(Imposto outro_imposto) : base(outro_imposto)
        {
        }

        protected override bool DeveUsarMaximaTaxacao(double valor)
        {
            if (valor > 500)
                return true;
            else
                return false;
        }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orc)
        {
            if (orc.Valor > 500)
                return true;
            else
                return false;
        }

        protected override double MaximaTaxacao(double valor)
        {
            return valor * 0.05;
        }

        protected override double MaximaTaxacao(Orcamento orc)
        {
            return orc.Valor * 0.05;
        }

        protected override double MinimaTaxacao(double valor)
        {
            return valor * 0.07;
        }

        protected override double MinimaTaxacao(Orcamento orc)
        {
            return orc.Valor * 0.07;
        }
    }
    #endregion 

    #region IKCV
    public class IKCV : TemplateImpostoCondicional
    {

        public IKCV() : base() { }
        public IKCV(Imposto outro_imposto) : base(outro_imposto)
        {
        }

        protected override bool DeveUsarMaximaTaxacao(double valor)
        {
            if (valor > 500 && hasItemMaior100(valor))
                return true;
            else
                return false;
        }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orc)
        {
            if (orc.Valor > 500 && hasItemMaior100(orc))
                return true;
            else
                return false;
        }

        protected override double MaximaTaxacao(double valor)
        {
            throw new NotImplementedException();
        }

        protected override double MaximaTaxacao(Orcamento orc)
        {
            return orc.Valor * 0.10;
        }

        protected override double MinimaTaxacao(double valor)
        {
            throw new NotImplementedException();
        }

        protected override double MinimaTaxacao(Orcamento orc)
        {
            return orc.Valor * 0.06;
        }

        private bool hasItemMaior100(Orcamento orc)
        {
            foreach (Item i in orc.Itens)
            {
                if (i.Valor > 100)
                    return true;
            }
            return false;
        }


        private bool hasItemMaior100(double valor)
        {
            return valor > 100;
        }
    }
    #endregion 

    #region IHIT
    public class IHIT : TemplateImpostoCondicional
    {

        public IHIT() : base()  { }
        public IHIT(Imposto outro_imposto) : base(outro_imposto)
        {
        }

        protected override bool DeveUsarMaximaTaxacao(double valor)
        {
            throw new NotImplementedException();
        }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orc)
        {
            List<String> nomeItens = new List<string>();
            foreach (Item i in orc.Itens)
            {
                if (nomeItens.Contains(i.Nome.ToUpper()))
                        return true;
                                    
            }
            return false;
        }

        protected override double MaximaTaxacao(double valor)
        {
            throw new NotImplementedException();
        }

        protected override double MaximaTaxacao(Orcamento orc)
        {
            return (orc.Valor * 0.13)+100;
        }

        protected override double MinimaTaxacao(double valor)
        {
            throw new NotImplementedException();
        }

        protected override double MinimaTaxacao(Orcamento orc)
        {
            if (orc.Itens.Count > 0)
            {
              return orc.Valor * (0.01 * orc.Itens.Count);
            }
                
            else
                return 0;
        }



    }
    #endregion

    #region  IMA 
    public class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto() : base(){ }
        public ImpostoMuitoAlto(Imposto outroImposto) : base(outroImposto) { }

        public override double Calcula(double valor)
        {
            throw new NotImplementedException();
        }

        public override double Calcula(Orcamento orc)
        {
            return (orc.Valor * 0.2) + this.CalculoOutroImposto(orc);
        }
    }
    #endregion



}
