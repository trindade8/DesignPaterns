using DesignPaterns.Builders;
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
    public partial class uiNotaFiscal : Form
    {
        public uiNotaFiscal()
        {
            InitializeComponent();
        }

        private NotaFiscal nota { get; set; }
        BuilderNotaFiscal builder { get; set; }


        private void btnCarregarNF_Click(object sender, EventArgs e)
        {
            this.CriaNf();
        }

        public void CriaNf()
        {
            this.builder = new BuilderNotaFiscal();
            List<Imposto> impostos = new List<Imposto>();
            impostos.Add(new ICMS());

            builder.ComCnpj("13465498797")
            .ParaEmpresa("Geper Desevenvolvimento de Sistemas")
            .ComItem(new ItemDaNota("Item 1", 20, impostos))
            .ComItem(new ItemDaNota("Item 1", 28, impostos))
            .ComItem(new ItemDaNota("Item 1", 23, impostos))
            .ComObservacoes("Pagamento na data de Entrega ")
            .NaData(DateTime.Now);
            this.nota = builder.Constroi();
            this.txtVisualzacaoNF.Text = this.nota.GeraRelatorio();
            this.nota.Criaxml();


        }
    }
}
