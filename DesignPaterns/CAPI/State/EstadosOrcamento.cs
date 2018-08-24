using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPaterns.Stratedy;

namespace DesignPaterns.State
{
    public class EmAprovacao : IEstadosOrcamento
    {
        bool AplicouDescontoExtra { get; set; }
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!AplicouDescontoExtra)
            {
                orcamento.AdicionaDesconto(orcamento.Valor * 0.05);
                AplicouDescontoExtra = true;
            }
            else
            {
                throw new Exception("Desconto ja aplicado");
            }
                

        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.estadoOrcamento = new OrcamentoAprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento Em Aprovação : o mesmo não pode ser Finalizado!");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.estadoOrcamento = new OrcamentoReprovado();
        }
    }

    public class OrcamentoAprovado : IEstadosOrcamento
    {
        private bool AplicouDescontoExtra { get; set; }
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!AplicouDescontoExtra)
            {
                orcamento.AdicionaDesconto(orcamento.Valor * 0.02);
                AplicouDescontoExtra = true;
            }
            else
                throw new Exception("Desconto ja aplicado");
            
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está Aprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.estadoOrcamento = new OrcamentoFinalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está Aprovado, o mesmo não pode ser Reprovado"); 
        }
    }

    public class OrcamentoFinalizado : IEstadosOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento está Finalizado, não é possivel aplicar novo desconto");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está Finalizado, não é possivel aprovar o Orcamento novamente");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já se encronta Finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está Finalizado, não é possivel reprovar o Orçamento");
        }
    }

    public class OrcamentoReprovado : IEstadosOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento está REPROVADO, não é possivel aplicar novo desconto");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está REPROVADO, não é possivel APROVAR o Orçamento");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento está REPROVADO, não é possivel FINALIZAR o Orçamento");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está REPROVADO");
        }
    }
}
