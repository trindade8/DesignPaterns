using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DesignPaterns.Stratedy.Investimentos;

namespace DesignPaterns
{

    

    public partial class uiInvestimento : Form
    {
        private double ValorInvestido { get
            {
                try
                {
                    double valor = double.Parse(txtValorInvestido.Text);
                    return valor;
                }
                catch (Exception e)
                {
                    return 0;
                }
                
            }
        }

        private Conservador Conservador { get; set; }
        private Moderado Moderado { get; set; }
        private Arrojado Arrojado { get; set; }
        private CalculadoraInvestimento calculadora { get; set; }


        public uiInvestimento()
        {
            InitializeComponent();
            InicializaObjetos();
        }

        private void InicializaObjetos()
        {
            this.Conservador = new Conservador();
            this.Moderado = new Moderado();
            this.Arrojado = new Arrojado();

        }

        private void CalculaLucroConservador()
        {
            this.calculadora = new CalculadoraInvestimento(this.ValorInvestido, this.Conservador);
            this.txtConservador.Text = this.calculadora.CalculaLucro().ToString();
        }

        private void CalculaLucroModerado()
        {
            this.calculadora = new CalculadoraInvestimento(this.ValorInvestido, this.Moderado);
            this.txtModerado.Text = this.calculadora.CalculaLucro().ToString();
            this.lblModerado.Text = this.Moderado.txtInvestimento();
        }

        private void CalculaLucroArrojado()
        {
            this.calculadora = new CalculadoraInvestimento(this.ValorInvestido, this.Arrojado);
            this.txtArrojado.Text = this.calculadora.CalculaLucro().ToString();
            this.lnlArrojado.Text = this.Arrojado.LucroRetorno;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            this.CalculaLucroConservador();
            this.CalculaLucroModerado();
            this.CalculaLucroArrojado();
        }
    }
}
