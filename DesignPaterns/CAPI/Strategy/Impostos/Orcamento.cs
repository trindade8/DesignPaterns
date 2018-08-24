using DesignPaterns.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPaterns.Stratedy
{
   public  class Orcamento
    {
        #region Propriedades
         public  double Valor { get{return ValorOrcamento();}  }
         public  double Desconto { get; private set; }
         private double _valorItens{
            get
            {
                try
                {
                    return this.Itens.Sum(i => i.Valor);
                }
                catch (Exception exp)
                {

                    return 0;
                }
            }
         }
         public  List<Item> Itens { get; set; }
         public  IEstadosOrcamento estadoOrcamento {get;set;}
        #endregion

        #region Construtores 
        public Orcamento()
        {
            this.estadoOrcamento = new EmAprovacao();
        }

        public Orcamento(double valorItemGenerico)
        {
            this.SetItem(Item.newItemGenerico(valorItemGenerico));
            this.estadoOrcamento = new EmAprovacao();
        }
        #endregion

        #region Metodos  Aux da Classe 
        protected double ValorOrcamento()
        {
            if (Desconto < _valorItens)
                return _valorItens - Desconto;
            else
                return _valorItens;

        }
        public void AdicionaDesconto(double desconto)
        {
            if (desconto < _valorItens && (desconto + Desconto <= _valorItens))
                this.AddDesconto(desconto);
        }

        private void AddDesconto(double desconto)
        {

            this.Desconto += desconto;
        }

        private void SetDesconto(double desconto)
        {
            this.Desconto = desconto;
        }

        public void ClearItens()
        {
            this.Itens.Clear();
        }



        public void SetItem(Item i)
        {
            if (this.Itens != null)
                this.Itens.Add(i);
            else
            {
                this.Itens = new List<Item>();
                this.SetItem(i);
            }
        }

        public int CountItens()
        {
            try
            {
                return this.Itens.Count;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        #endregion

        #region Metodos de Aprovacao Orcamento
        public void Aprova()
        {
            try
            {
                this.estadoOrcamento.Aprova(this);
            }
            catch (Exception exp)
            {

                System.Windows.Forms.MessageBox.Show(exp.Message);
            }
            
        }

        public void AplicaDescontoStatus()
        {
            try
            {
                this.estadoOrcamento.AplicaDescontoExtra(this);
            }
            catch (Exception exp)
            {

                System.Windows.Forms.MessageBox.Show(exp.Message);
            }
        }

        public void Finaliza()
        {
            try
            {
                this.estadoOrcamento.Finaliza(this);
            }
            catch (Exception exp)
            {

                System.Windows.Forms.MessageBox.Show(exp.Message);
            }
        }
        public void Reprova()
        {
            try
            {
                this.estadoOrcamento.Reprova(this);
            }
            catch (Exception exp)
            {

                System.Windows.Forms.MessageBox.Show(exp.Message);
            }
        }
        #endregion


    }

    public class Item
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public static Item newInstance(String nome, double valor)
        {
           Item i = new Item { Nome = nome, Valor = valor };
            return i;
        }

        public static Item newItemGenerico(double valor)
        {
            Item i = new Item { Nome = "itemGenerico", Valor = valor };
            return i;
        }


    }

}
