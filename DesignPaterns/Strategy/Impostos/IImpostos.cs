using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPaterns.Stratedy
{
    public interface IImpostos
    {
        Double Calcula(Orcamento orc);
    }
}
