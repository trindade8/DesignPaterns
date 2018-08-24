using DesignPaterns.ChainOfResponsability.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPaterns.Decorator
{
    #region Abstracao
    public abstract class FiltroConta
    {
        protected FiltroConta outroFiltro { get; set; }

        public FiltroConta() { }
        public FiltroConta(FiltroConta filtro)
        {
            this.outroFiltro = filtro;
        }

        public abstract List<Conta> FiltraConta(List<Conta> contas);

        public List<Conta> UtilizaOutroFiltro(List<Conta> contas)
        {
            if (this.outroFiltro == null) return new List<Conta>();
            return this.outroFiltro.FiltraConta(contas);
        }
    }
    #endregion


    public class FiltroContasMenorCemReais : FiltroConta
    {
        public FiltroContasMenorCemReais() : base() { }
        public FiltroContasMenorCemReais(FiltroContasMenorCemReais filtro) 
            : base(filtro) { }

        public override List<Conta> FiltraConta(List<Conta> contas)
        {
            List<Conta> NovaLista = new List<Conta>();
            foreach (Conta c in contas)
            {
                if (c.ValorConta < 100)
                    NovaLista.Add(c);
            }
            foreach (Conta co in this.UtilizaOutroFiltro(contas))
            {
                NovaLista.Add(co);
            }
            return NovaLista;
        }
    }

    public class FiltroContasMaiorQuitentosMil : FiltroConta
    {
        public FiltroContasMaiorQuitentosMil() : base(){ }
        public FiltroContasMaiorQuitentosMil(FiltroConta filtro) : base(filtro) { }

        public override List<Conta> FiltraConta(List<Conta> contas)
        {
            List<Conta> NovaLista = new List<Conta>();
            foreach (Conta c in contas)
            {
                if (c.ValorConta > 500000)
                    NovaLista.Add(c);
            }
            foreach (Conta co in this.UtilizaOutroFiltro(contas))
            {
                NovaLista.Add(co);
            }


            return NovaLista;
        }
    }

    public class FiltroContasMesCorrente : FiltroConta
    {
        public FiltroContasMesCorrente() : base() { }
        public FiltroContasMesCorrente(FiltroConta filtro) : base(filtro) { }
        public override List<Conta> FiltraConta(List<Conta> Contas)
        {
            List<Conta> novaLista = new List<Conta>();
            foreach (Conta c in Contas)
            {
                if (c.DataAbertura.Month.Equals(DateTime.Now.Month)
                    && c.DataAbertura.Year.Equals(DateTime.Now.Year))
                {
                    novaLista.Add(c);
                }
            }
            foreach (Conta co in this.UtilizaOutroFiltro(Contas))
            {
                novaLista.Add(co);
            }
            return novaLista;
        }
    }
}
