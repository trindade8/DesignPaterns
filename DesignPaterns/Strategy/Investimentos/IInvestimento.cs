using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPaterns.Stratedy.Investimentos
{
    public interface IInvestimento
    {
        double Calcula(double valorInvestido);
    }
}
