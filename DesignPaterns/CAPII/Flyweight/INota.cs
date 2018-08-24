using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPaterns.CAPII.Flyweight
{
    public interface INota
    {
        int Frequencia { get; }
        string ToString();

    }

    public class Do : INota
    {
        public int Frequencia { get { return 262; } }

        public override string ToString()
        {
            return this.GetType().Name.ToLower();
        }
    }

    public class Re : INota
    {
        public int Frequencia { get { return 294; } }

        public override string ToString()
        {
            return this.GetType().Name.ToLower();
        }

    }

    public class Mi : INota
    {
        public int Frequencia { get { return 330; } }

        public override string ToString()
        {
            return this.GetType().Name.ToLower();
        }
    }

    public class Fa : INota
    {
        public int Frequencia { get { return 349; } }

        public override string ToString()
        {
            return this.GetType().Name.ToLower();
        }
    }

    public class Sol : INota
    {
        public int Frequencia { get { return 392; } }

        public override string ToString()
        {
            return this.GetType().Name.ToLower();
        }
    }

    public class La : INota
    {
        public int Frequencia { get { return 440; } }

        public override string ToString()
        {
            return this.GetType().Name.ToLower();
        }
    }

    public class Si : INota
    {
        public int Frequencia { get { return 490; } }

        public override string ToString()
        {
            return this.GetType().Name.ToLower();
        }
    }

}
