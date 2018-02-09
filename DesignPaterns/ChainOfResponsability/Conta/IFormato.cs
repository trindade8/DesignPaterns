using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPaterns.ChainOfResponsability.Conta
{
    public interface IFormato
    {
        string Formatar( Requisicao requisicao,Conta conta);
    }
}
