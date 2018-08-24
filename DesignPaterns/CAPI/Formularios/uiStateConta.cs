using DesignPaterns.ChainOfResponsability.Conta;
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
    public partial class uiStateConta : Form
    {
        public uiStateConta()
        {
            InitializeComponent();
            InicialzaContaTeste();
            this.SetDadosConta(this.conta);
        }

        public Conta conta { get; set; }
        private double valorOperacao
        {
            get
            {
                try
                {
                    return Double.Parse(this.txtValorOperacao.Text);
                }
                catch (Exception)
                {

                    return 0;
                }
            }
        }

        public void InicialzaContaTeste()
        {
            this.conta = new Conta("Wesley", 0);
        }
        private void SetValorConta(string s)
        {
            this.labelSaldoConta.Text = s;
        }

        private void SetTitularConta(string s)
        {
            this.lblNomeTitularConta.Text = s;
        }


        private void SetDadosConta(Conta conta)
        {
            this.SetValorConta(conta.ValorConta.ToString("N2"));
            this.SetTitularConta(conta.NomeTitular);
        }

        

        private void btnSaca_Click(object sender, EventArgs e)
        {
            try
            {
                this.conta.Saca(this.valorOperacao);
                this.SetDadosConta(this.conta);
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void btnDeposita_Click(object sender, EventArgs e)
        {
            try
            {
                this.conta.Deposita(this.valorOperacao);
                this.SetDadosConta(this.conta);
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }
    }
}
