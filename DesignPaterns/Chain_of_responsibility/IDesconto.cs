using DesignPaterns.Stratedy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPaterns.Chain_of_responsibility
{
    public interface IDesconto
    {
        double Calcula(Orcamento orc);
    }
}
