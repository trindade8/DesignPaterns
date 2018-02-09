using DesignPaterns.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPaterns.Observer
{
   public  interface IAcoesPosProcessamentoNFe
    {
        void Executa(NotaFiscal nf);
    }

    public class CriaXML : IAcoesPosProcessamentoNFe
    {
        public void Executa(NotaFiscal nf)
        {
            nf.Criaxml();
        }
    }

    public class PersisteNotaBanco : IAcoesPosProcessamentoNFe
    {
        public void Executa(NotaFiscal nf)
        {
            System.Windows.Forms.MessageBox.Show("Nota Salva ! ");
        }
    }


    public class Multiplicador : IAcoesPosProcessamentoNFe
    {

        public double Fator { get; set; }

        public Multiplicador(double fator)
        {
            this.Fator = fator;
        }
        public void Executa(NotaFiscal nf)
        {
            System.Windows.Forms.MessageBox.Show("Fator Multiplicador : "+(this.Fator * nf.ValorBruto).ToString("N2"));
        }

        
    }



    public class EnviaEmail : IAcoesPosProcessamentoNFe
    {
        public void Executa(NotaFiscal nf)
        {
            System.Windows.Forms.MessageBox.Show("Danfe Enviada por E-mail ! ");
        }
    }

}
