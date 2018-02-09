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
        private IKCV IKCV { get; set; }
        private ICPP ICPP { get; set; }
        private IHIT IHIT { get; set; }
        private ImpostoMuitoAlto IMA { get; set; }

        CalculadorDeImposto calc { get; set; }

        public void IniciaObjetos()
        {
            this.orc  = new Orcamento();
            this.ICMS = new ICMS(new ICMS());
            this.ISS = new ISS();
            this.ICCC = new ICCC();
            this.IKCV = new IKCV();
            this.ICPP = new ICPP();
            this.IHIT = new IHIT();
            this.IMA = new ImpostoMuitoAlto(new ICMS());

        }

        

        private void SetValorOrcamento()
        {
            try
            {
                Double valor = Double.Parse(txtValorOrcamento.Text);
                this.orc.SetItem(Item.newItemGenerico(valor));
            }
            catch (Exception e)
            {
                this.orc.SetItem(Item.newItemGenerico(0));
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

        private void CalculaIKCV()
        {
            this.calc = new CalculadorDeImposto(this.orc, this.IKCV);
            txtikcv.Text = calc.CalculaImposto().ToString();
        }

        private void CalculaICPP()
        {
            this.calc = new CalculadorDeImposto(this.orc, this.ICPP);
            txticpp.Text = calc.CalculaImposto().ToString();
        }

        private void CalculaIHIT()
        {
            this.calc = new CalculadorDeImposto(this.orc, this.IHIT);
            txtIHIT.Text = calc.CalculaImposto().ToString();
        }

        private void CalculaIMA()
        {
            this.calc = new CalculadorDeImposto(this.orc, this.IMA);
            txtIMA.Text = calc.CalculaImposto().ToString();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            this.SetValorOrcamento();
            this.CalculaICMS();
            this.CalculaISS();
            this.CalculaICCC();
            this.CalculaIKCV();
            this.CalculaICPP();
            this.CalculaIHIT();
            this.CalculaIMA();
        }
    }
}
