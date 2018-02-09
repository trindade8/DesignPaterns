using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;


namespace DesignPaterns.ChainOfResponsability.Conta
{
    public partial class uiFormataConta : Form
    {




        public uiFormataConta()
        {
            InitializeComponent();
        }


        public void loadCombobox()
        {
            List<Dropvalue> AL = new List<Dropvalue>();
            Dropvalue xml = new Dropvalue(0, "XML");
            Dropvalue csv = new Dropvalue(1, "CSV");
            Dropvalue porcentagem = new Dropvalue(2, "Porcentagem");
            AL.Add(xml);
            AL.Add(csv);
            AL.Add(porcentagem);
            comboFormato.DisplayMember = "Descricao";
            comboFormato.ValueMember = "Codigo";

            comboFormato.DataSource = AL;
        }

        private void uiFormConta_Load(object sender, EventArgs e)
        {
            loadCombobox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enumFormato formato = (enumFormato)Int32.Parse(this.comboFormato.SelectedValue.ToString());
            string nome = txtnome.Text.ToString();
            double valor = Double.Parse(txtValor.Text.ToString());
            Conta c = new Conta(nome, valor);
            Requisicao req = new Requisicao(formato);
            ProcessaRequisicao pr = new ProcessaRequisicao();
            string retorno = pr.FormatarConta(req, c);
            this.txtResultadoProcessamento.Text = retorno;



        }


        public static void CriaXML(Conta p )
        {
            XmlDocument doc = new XmlDocument();
            //(1) the xml declaration is recommended, but not mandatory
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            //(2) string.Empty makes cleaner code
            XmlElement element1 = doc.CreateElement(string.Empty, "body", string.Empty);
            doc.AppendChild(element1);

            XmlElement element2 = doc.CreateElement(string.Empty, "level1", string.Empty);
            element1.AppendChild(element2);

            XmlElement element3 = doc.CreateElement(string.Empty, "level2", string.Empty);
            XmlText text1 = doc.CreateTextNode("text");
            element3.AppendChild(text1);
            element2.AppendChild(element3);

            XmlElement element4 = doc.CreateElement(string.Empty, "level2", string.Empty);
            XmlText text2 = doc.CreateTextNode("other text");
            element4.AppendChild(text2);
            element2.AppendChild(element4);

            doc.Save("C:\\Gransoft\\document.xml");
        }

        private void btnCriaxml_Click(object sender, EventArgs e)
        {
            string nome = txtnome.Text.ToString();
            double valor = Double.Parse(txtValor.Text.ToString());
            Conta conta = new Conta(nome, valor);
            CriaXML(conta);
            
        }
    }


    
}
