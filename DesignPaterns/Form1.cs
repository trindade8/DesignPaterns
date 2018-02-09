using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DesignPaterns.Stratedy;

namespace DesignPaterns
{
    public partial class uiForm : Form
    {
        public uiForm()
        {
            InitializeComponent();
            IniciaObjetos();
        }

        private Orcamento orc { get; set; }
        private ISS ISS { get; set; }
        private ICMS ICMS {get;set;}
        private ICCC ICCC { get; set; }
        CalculadorDeImposto calc { get; set; }

        public void IniciaObjetos()
        {
            this.orc  = new Orcamento(0);
            this.ICMS = new ICMS();
            this.ISS = new ISS();
            this.ICCC = new ICCC();
            
        }

        

        private void SetValorOrcamento()
        {
            try
            {
                Double valor = Double.Parse(txtValorOrcamento.Text);
                this.orc.SetValor(valor);
            }
            catch (Exception e)
            {
                this.orc.SetValor(0);
            }
        }

        private void CalculaICMS()
        {
            this.calc = new CalculadorDeImposto(this.orc, this.ICMS);
            txtValorICMS.Text = calc.CalculaImposto().ToString();
        }

        private void CalculaISS()
        {
            this.calc = new CalculadorDeImposto(this.orc, this.ISS);
            txtValorISS.Text = calc.CalculaImposto().ToString();
        }

        private void CalculaICCC()
        {
            this.calc = new CalculadorDeImposto(this.orc, this.ICCC);
            txtValorICCC.Text = calc.CalculaImposto().ToString();
        }


        private void btnCalcula_Click(object sender, EventArgs e)
        {
            this.SetValorOrcamento();
            this.CalculaICMS();
            this.CalculaISS();
            this.CalculaICCC();
        }
    }
}
