using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPaterns.ChainOfResponsability.Conta
{
    
    public enum enumFormato
    {
        XML,
        CSV,
        PORCENTO

    }

    public abstract class Formato : IFormato
    {
        public enumFormato tipo { get; set; }
        public IFormato next { get; set; }
        public abstract string Formatar(Requisicao requisicao, Conta conta);

         
        public void SetNext(IFormato formato)
        {
            this.next = formato;
        }


        
    }

    public class FormatoXml : Formato
    {
        public FormatoXml()
        {
            this.tipo = enumFormato.XML;
        }
        public override string Formatar(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato.Equals(this.tipo))
            {
                return FormataConta(conta);
            }
            else
            {
                return this.next.Formatar(requisicao, conta);
            }
        }

        private string FormataConta(Conta c)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<conta><Nome>").Append(c.NomeTitular).Append("</Nome>");
            sb.Append("<Valor>").Append(c.ValorConta).Append("</Valor></conta>");
            return sb.ToString();

        }
    }

    public class FormatoCSV : Formato
    {
        public FormatoCSV()
        {
            this.tipo = enumFormato.CSV;
        }
        public override string Formatar(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato.Equals(this.tipo))
                return conta.NomeTitular + ";" + conta.ValorConta.ToString("N2") + ";";
            else
                return this.next.Formatar(requisicao, conta);
        }


    }

    public class FormatoPorcentagem : Formato
    {

        public FormatoPorcentagem()
        {
            this.tipo = enumFormato.PORCENTO;
        }
        public override string Formatar(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato.Equals(this.tipo))
                return conta.NomeTitular + "%" + conta.ValorConta.ToString("N2") + "%";
            else
                return this.next.Formatar(requisicao, conta);

        }

    }


    public class Requisicao
    {
        public enumFormato Formato { get; set; }
        public Requisicao(enumFormato formato)
        {
            this.Formato = formato;
        }
    }

   public class  ProcessaRequisicao  
    {
        private Formato formato { get; set; }
        public ProcessaRequisicao()
        {
            FormatoXml formatoXML = new FormatoXml();
            FormatoCSV formatoCSV = new FormatoCSV();
            FormatoPorcentagem formatoPorct = new FormatoPorcentagem();
            formatoXML.SetNext(formatoCSV);
            formatoCSV.SetNext(formatoPorct);
            this.formato = formatoXML;


        }

        public string FormatarConta(Requisicao requisicao, Conta conta)
        {
            return this.formato.Formatar(requisicao, conta);
        }


    }
}
