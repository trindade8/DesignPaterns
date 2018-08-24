using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPaterns.CAPII.Flyweight
{
   public class NotasMusicais
    {

        private static IDictionary<string, INota> notas = new Dictionary<string, INota>()
        {
            { "do",new Do()},
            { "re",new Re()},
            { "mi",new Mi()},
            { "fa",new Fa()},
            { "sol",new Sol()},
            { "la",new La()},
            { "si",new Si()},
        };

        public INota Pega(String name)
        {
            return notas[name];
        }

        public  static List<String> getNameNotas()
        {
            return notas.Keys.ToList();
        }
    }
}
