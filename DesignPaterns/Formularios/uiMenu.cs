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
    public partial class uiMenu : Form
    {
        public uiMenu()
        {
            InitializeComponent();
            SetEventos();
            this.txtIdSessao.Text = Guid.NewGuid().ToString();
        }


        private void SetEventos()
        {
            this.investimentosToolStripMenuItem.Click += onClickMenu;
            this.tributaçõesToolStripMenuItem.Click += onClickMenu;
            this.descontosToolStripMenuItem.Click += onClickMenu;
            this.formataContaToolStripMenuItem.Click += onClickMenu;
            this.relatorioBancoToolStripMenuItem.Click += onClickMenu;
            this.stateContaToolStripMenuItem.Click += onClickMenu;
            this.notaFiscalToolStripMenuItem.Click += onClickMenu;
            this.toolStripMenuItem1.Click += onClickMenu;
        }


        public void onClickMenu(object sender , EventArgs evento)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            OpenForm(item.Name);

            //switch (item.Name)
            //{
            //    case "tributaçõesToolStripMenuItem":
            //        uiForm t = new uiForm();
            //        t.ShowDialog(); 
            //        break;

            //    case "investimentosToolStripMenuItem":
            //        uiInvestimento i = new uiInvestimento();
            //        i.ShowDialog();
            //        break;
            //    case "descontosToolStripMenuItem":
            //        uiDesconto d = new uiDesconto();
            //        d.ShowDialog();
            //        break;
            //    case "formataContaToolStripMenuItem":
                    
            //        uiFormataConta f = new uiFormataConta();
            //        f.ShowDialog();
            //        break;
            //    case "relatorioBancoToolStripMenuItem":
            //        uiRelatorio r = new uiRelatorio();
            //        r.ShowDialog();
            //        break;
            //    case "stateContaToolStripMenuItem":
            //        uiStateConta s = new uiStateConta();
            //        s.ShowDialog();
            //        break;
            //    case "notaFiscalToolStripMenuItem":
            //        uiNotaFiscal n = new uiNotaFiscal();
            //        n.ShowDialog();
            //        break;

            //}



        }

        private void uiMenu_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F3:
                    OpenForm("tributaçõesToolStripMenuItem");
                    break;


            }
        }


        private void OpenForm(string nameForm)
        {
            switch (nameForm)
            {
                case "tributaçõesToolStripMenuItem":
                    uiForm t = new uiForm();
                t.ShowDialog();
                break;

                case "investimentosToolStripMenuItem":
                    uiInvestimento i = new uiInvestimento();
                i.ShowDialog();
                break;
                case "descontosToolStripMenuItem":
                    uiDesconto d = new uiDesconto();
                d.ShowDialog();
                break;
                case "formataContaToolStripMenuItem":
                    
                    uiFormataConta f = new uiFormataConta();
                f.ShowDialog();
                break;
                case "relatorioBancoToolStripMenuItem":
                    uiRelatorio r = new uiRelatorio();
                r.ShowDialog();
                break;
                case "stateContaToolStripMenuItem":
                    uiStateConta s = new uiStateConta();
                s.ShowDialog();
                break;
                case "notaFiscalToolStripMenuItem":
                    uiNotaFiscal n = new uiNotaFiscal();
                n.ShowDialog();
                break;

                case "toolStripMenuItem1":
                    FormTeste fm = new FormTeste();
                    fm.ShowDialog();
                    break;

            }
        }
    }
}
