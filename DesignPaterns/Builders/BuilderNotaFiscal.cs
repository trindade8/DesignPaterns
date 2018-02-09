using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPaterns.Builders
{
    public class BuilderNotaFiscal
    {
        public string RazaoSocial { get; private set; }
        public string CNPJ { get; private set; }
        public double Impostos { get; set; }
        public DateTime DataEmissao { get; private set; }
        public string Obervacoes { get; private set; }
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        public BuilderNotaFiscal()
        {
            this.DataEmissao = DateTime.Now;
        }

        public BuilderNotaFiscal ParaEmpresa(String empresa)
        {
            this.RazaoSocial = empresa;
            return this;
        }

        public BuilderNotaFiscal ComCnpj(String cnpj)
        {
            this.CNPJ = cnpj;
            return this;
        }

        public BuilderNotaFiscal ComImpostos(double impostos)
        {
            this.Impostos += impostos;
            return this;
        }

        public BuilderNotaFiscal ComItem(ItemDaNota item)
        {
            this.todosItens.Add(item);
            this.ComImpostos(item.CalculaTotalImposto());
            return this;
        }

        public BuilderNotaFiscal NaDataAtual() { this.DataEmissao = DateTime.Now; return this; }

        internal BuilderNotaFiscal NaData(DateTime data)
        {
            this.DataEmissao = data;
            return this;
        }

        public BuilderNotaFiscal ComObservacoes(String observacao)
        {
            this.Obervacoes = observacao;
            return this;
        }

        public NotaFiscal Constroi()
        {
            return  new NotaFiscal(this.RazaoSocial, this.CNPJ, this.Impostos, this.DataEmissao, this.Obervacoes,this.todosItens);
        }
        
    }
}
