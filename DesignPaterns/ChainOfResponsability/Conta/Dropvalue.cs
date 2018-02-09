using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPaterns.ChainOfResponsability.Conta
{
    public class Dropvalue
    {
        public int Codigo { get; set; }
        public String Descricao { get; set; }

        public Dropvalue(int Codigo, string Descricao)
        {
            this.Codigo = Codigo;
            this.Descricao = Descricao;
        }

    }
}
