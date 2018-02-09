using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPaterns.Stratedy;
namespace DesignPaterns.State
{
    public interface IEstadosOrcamento
    {
        
        void AplicaDescontoExtra(Orcamento orcamento);

        void Reprova(Orcamento orcamento);
        void Aprova(Orcamento orcamento);
        void Finaliza(Orcamento orcamento);
        
        

    }
}
