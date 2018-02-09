using DesignPaterns.Stratedy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPaterns.ChainOfResponsability
{
    public interface IDesconta
    {
        

        double Desconta(Orcamento orc);
    }
}
