using DesignPaterns.ChainOfResponsability.Conta;
using DesignPaterns.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DesignPaterns.TemplateMethod
{
    public abstract class Relatorio
    {

        
        protected abstract void CriaCabecalho();
        protected abstract void CriaCriaCorpo();
        protected abstract void CriaRodape();
        public abstract void ExibeRelatorio();
        public void CriaRelatorio()
        {
            CriaCabecalho();
            CriaCriaCorpo();
            CriaRodape();
        }

        


    }

    public class RelatorioSimples : Relatorio
    {
        private Banco Banco { get; set; }
        private StringBuilder builderRelatorio { get; set; }
        public RelatorioSimples(Banco banco)
        {
            this.Banco = banco;
            this.builderRelatorio = new StringBuilder();
        }

        protected override void CriaCabecalho()
        {
            this.builderRelatorio.Append("### ")
                .Append("Banco:").Append(this.Banco.Nome).Append(" ")
                .Append("Telefone:").Append(this.Banco.Telefone).Append(" ")
                .Append("Relatório Simples")
                .Append(" ###")
                .AppendLine();
        }

        protected override void CriaCriaCorpo()
        {

            this.builderRelatorio.Append("Contas->").AppendLine();
            foreach(Conta c in this.Banco.Contas)
            {
                this.builderRelatorio.Append("Titular:").Append(c.NomeTitular).Append(" | ")
                    .Append("Saldo :").Append(c.ValorConta)
                    .AppendLine();
            }
        }

        protected override void CriaRodape()
        {
            this.builderRelatorio.Append("### ")
               .Append("Banco:").Append(this.Banco.Nome).Append(" ")
               .Append("Telefone:").Append(this.Banco.Telefone).Append(" ")
               .Append("Fim Relatório Simples")
               .Append(" ###")
               .AppendLine();
        }

        public override void ExibeRelatorio()
        {
            uiExibicaoRelatorio ui = new uiExibicaoRelatorio(this.builderRelatorio.ToString());
            ui.ShowDialog();
        }
    }

    public class RelatorioComplexo : Relatorio
    {

        private Banco Banco { get; set; }
        private StringBuilder builderRelatorio { get; set; }

        public RelatorioComplexo(Banco banco)
        {
            this.Banco = banco;
            this.builderRelatorio = new StringBuilder();
        }
        protected override void CriaCabecalho()
        {
            this.builderRelatorio.Append("### ")
               .Append("Banco:").Append(this.Banco.Nome).Append(" ")
               .Append("Telefone:").Append(this.Banco.Telefone).Append(" ")
               .Append("Endereço:").Append(this.Banco.Endereco).Append(" ")
               .Append("E-mail:").Append(this.Banco.Email).Append(" ")
               .Append("Data :").Append(DateTime.Now.ToShortDateString()).Append(" ")
               .Append(" Fim Relatório Complexo")
               .Append(" ###")
               .AppendLine();
        }

        protected override void CriaCriaCorpo()
        {
            this.builderRelatorio.Append("Contas->").AppendLine();
            foreach (Conta c in this.Banco.Contas)
            {
                this.builderRelatorio
                    .Append("Titular:").Append(c.NomeTitular).Append(" | ")
                    .Append("Agência:").Append(c.Agencia).Append(" | ")
                    .Append("Conta:").Append(c.NumeroConta).Append(" | ")
                    .Append("Saldo :").Append(c.ValorConta)
                    .AppendLine();
            }
        }

        protected override void CriaRodape()
        {
            this.builderRelatorio.Append("### ")
              .Append("Banco:").Append(this.Banco.Nome).Append(" ")
              .Append("Telefone:").Append(this.Banco.Telefone).Append(" ")
              .Append("Endereço:").Append(this.Banco.Endereco).Append(" ")
              .Append("E-mail:").Append(this.Banco.Email).Append(" ")
              .Append("Data :").Append(DateTime.Now.ToShortDateString()).Append(" ")
              .Append(" Fim Relatório Complexo")
              .Append(" ###")
              .AppendLine();
        }

        public override void ExibeRelatorio()
        {
            uiExibicaoRelatorio ui = new uiExibicaoRelatorio(this.builderRelatorio.ToString());
            ui.ShowDialog();
        }
    }
}
