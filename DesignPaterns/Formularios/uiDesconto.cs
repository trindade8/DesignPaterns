using DesignPaterns.ChainOfResponsability;
using DesignPaterns.ChainOfResponsability.Conta;
using DesignPaterns.Stratedy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignPaterns.Formularios
{
    public partial class uiDesconto : Form
    {

        // propriedades
        private Orcamento orcamento { get; set; }
        private CalculadoraDesconto calculadora { get; set; }
        private double valorNovoItem{ get
            {
                try
                {
                    return double.Parse( this.txtValorNewItem.Text);
                }
                catch (Exception)
                {

                    return 0;
                }
            } }
        
        public uiDesconto()
        {
            InitializeComponent();
            this.IniciaObjetos();
            LoadComboFiltro();
        }

        public void IniciaObjetos()
        {
            this.orcamento = new Orcamento();
            this.calculadora = new CalculadoraDesconto(orcamento);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Item i;
            if (this.txtNome.Text.ToString().Length > 0)
            {

                i = Item.newInstance(this.txtNome.Text, this.valorNovoItem);

            }
            else
            {
                i = Item.newItemGenerico(this.valorNovoItem);
            }
            
            if(this.orcamento != null)
            {
                this.orcamento.SetItem(i);
            }
            SetValorOrcamento();
            ClearBoxItem();
        }

        private void ClearBoxItem()
        {
            this.txtNome.Text = String.Empty;
            this.txtValorNewItem.Text = String.Empty;
        }


        public void LoadComboFiltro()
        {
            List<Dropvalue> filtros = new List<Dropvalue>
            {
                 new Dropvalue(1,"Reprova"),
                 new Dropvalue(2,"Aprova"),
                 new Dropvalue(3,"Finaliza"),
            };
            this.cbxStatusOrcamento.DataSource = filtros;
            this.cbxStatusOrcamento.DisplayMember = "Descricao";
            this.cbxStatusOrcamento.ValueMember = "Codigo";

        }


        private void btnAplicaDescontoStatus_Click(object sender, EventArgs e)
        {
            int opcao = (int)this.cbxStatusOrcamento.SelectedValue;
            switch (opcao)
            {
                case 1:
                    this.orcamento.Reprova();
                    break;
                case 2:
                    this.orcamento.Aprova();
                    break;
                case 3:
                    this.orcamento.Finaliza();
                    break;
                default:
                    break;
            }

            this.txtDesconto.Text = this.orcamento.Desconto.ToString();
            this.txtTotalOrcamento.Text = this.orcamento.Valor.ToString();
        }


        private void SetValorOrcamento()
        {
            this.txtTotalOrcamento.Text = this.orcamento.Valor.ToString();
        }

        private void btnClearItens_Click(object sender, EventArgs e)
        {
            if (this.orcamento != null)
                this.orcamento.ClearItens();
            SetValorOrcamento();
        }

        private void btnAplicaDesconto_Click(object sender, EventArgs e)
        {
            this.setValorDesconto(this.calculadora.AplicaDesconto());
            this.setNomeDesconto(Desconto.Nome);
        }

        private void setValorDesconto(double valor)
        {
            this.txtDesconto.Text = valor.ToString();
        }
        private void setNomeDesconto(string nome)
        {
            lblInfoDesconto.Text = "Info : " + nome;
        }

        private void btnApplyDescontoStatus_Click(object sender, EventArgs e)
        {
            this.orcamento.AplicaDescontoStatus();
            this.txtDesconto.Text = this.orcamento.Desconto.ToString();
            this.txtTotalOrcamento.Text = this.orcamento.Valor.ToString();
        }
    }

   


}
