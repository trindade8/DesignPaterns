using DesignPaterns.ChainOfResponsability.Conta;
using DesignPaterns.Decorator;
using DesignPaterns.TemplateMethod;
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
    public partial class uiRelatorio : Form
    {

        private Banco banco { get; set; }
        private Relatorio rel { get; set; }



        public uiRelatorio()
        {
            InitializeComponent();
            LoadComboFiltro();
            InicializaDadosBanco();
        }


        private void InicializaDadosBanco()
        {
            this.banco = new Banco("Itau", "Conselheiro Nebias,238", "(13) 3323-4268", "contato@itauempresas.com.br");
            List<Conta> contas = new List<Conta>();

            for (int x = 0; x <= 10; x++)
            {
                Conta conta = new Conta("Wesley", 1500, "002", "1456-6");
                contas.Add(conta);
            }

            this.banco.SetContas(contas);

        }


        public void LoadComboFiltro()
        {
            List<Dropvalue> filtros = new List<Dropvalue>
            {
                 new Dropvalue(-1,""),
                 new Dropvalue(1,"Conta Menor Cem Reais"),
                 new Dropvalue(2,"Conta Maior Quitentos Mil"),
                 new Dropvalue(3,"Conta Mes Corrente"),
            };
            this.cmbFiltro.DataSource = filtros;
            this.cmbFiltro.DisplayMember = "Descricao";
            this.cmbFiltro.ValueMember = "Codigo";
            
        }
        

        private void btnSimples_Click(object sender, EventArgs e)
        {
            InicializaDadosBanco();
            this.banco.Contas = FiltrarContas(banco);
            this.rel = new RelatorioSimples(this.banco);
            this.rel.CriaRelatorio();
            this.rel.ExibeRelatorio();
        }

        private List<Conta> FiltrarContas(Banco banco)
        {
            int opcaoFiltro =(int) this.cmbFiltro.SelectedValue;
            FiltroConta filtro; 
            switch (opcaoFiltro)
            {
                case -1:
                    return banco.Contas;
                case 1:
                    filtro = new FiltroContasMenorCemReais();
                    return filtro.FiltraConta(banco.Contas);
                case 2:
                    filtro = new FiltroContasMaiorQuitentosMil();
                    return filtro.FiltraConta(banco.Contas);
                case 3:
                    filtro = new FiltroContasMesCorrente();
                    return filtro.FiltraConta(banco.Contas);
                default:
                    return banco.Contas;

            }
        }

        private void btnComplexo_Click(object sender, EventArgs e)
        {
            InicializaDadosBanco();
            this.banco.Contas = FiltrarContas(banco);
            this.rel = new RelatorioComplexo(this.banco);
            this.rel.CriaRelatorio();
            this.rel.ExibeRelatorio();
        }
    }
}
