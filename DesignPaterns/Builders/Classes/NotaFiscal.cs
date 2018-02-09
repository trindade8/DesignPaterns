using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace DesignPaterns.Builders
{
    public class NotaFiscal
    {

        public string   RazaoSocial { get; private set; }
        public string   CNPJ { get; private set; }
        public double   Impostos { get; set; }
        public DateTime DataEmissao { get; private set; }
        public string   Obervacoes { get;  private set; }
        public int Estado { set; get; }
        public string DV { get; set; }
        public double   ValorBruto
        {
            get
            {
                try
                {
                    return this.todosItens.Sum(i => i.ValorItem);
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }
        public IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        public NotaFiscal(string razaoSocial, string cNPJ, double impostos, DateTime dataEmissao, string obervacoes)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cNPJ;
            Impostos = impostos;
            DataEmissao = dataEmissao;
            Obervacoes = obervacoes;
            this.Estado = 35;
            this.DV = "01";
        }

        public NotaFiscal(string razaoSocial, string cNPJ, double impostos, DateTime dataEmissao, string obervacoes, IList<ItemDaNota> todosItens)
            : this(razaoSocial,cNPJ,impostos,dataEmissao,obervacoes)
        {
            this.todosItens = todosItens;
            
            
        }

        public string criaChaveNota()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Estado).Append(this.DataEmissao.ToString("yymm")).Append(this.CNPJ).Append("55").Append("001").Append("000000098").Append("136411778").Append(this.DV);
            return sb.ToString();
        }


        public String GeraRelatorio()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Chave de Acesso: ").Append(this.criaChaveNota()).AppendLine();
            sb.Append("Razão Social: ").Append(this.RazaoSocial).AppendLine(); 
            sb.Append("CNPJ: ").Append(this.CNPJ).AppendLine();
            sb.Append("Data Emissão: ").Append(this.DataEmissao).AppendLine();
            sb.Append("Itens : ").Append(this.DataEmissao).AppendLine().AppendLine();


            foreach (ItemDaNota d in this.todosItens)
            {
                sb.Append(d.ToString()).AppendLine();

            }

            sb.AppendLine().AppendLine();
            sb.Append("Valor Bruto: ").Append(this.ValorBruto).AppendLine();
            sb.Append("Observações: ").Append(this.Obervacoes).AppendLine();
             sb.Append("Impostos: ").Append(this.Impostos).AppendLine();
                        

            return sb.ToString();
        }

        public void Criaxml()
        {
            XmlDocument doc = new XmlDocument();
            
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);


            XmlElement nota = doc.CreateElement(string.Empty, "NotaFiscal", string.Empty);
            doc.AppendChild(nota);
            XmlNode ChaveNota = criaNode(doc, "ChaveNota", this.criaChaveNota());
            nota.AppendChild(ChaveNota);
            XmlNode Emitente = criaDadosEmitente(doc);
            nota.AppendChild(Emitente);
            XmlNode Itens = CriaItens(doc);
            nota.AppendChild(Itens);
            XmlNode DadosAdicionais = CriaDadosAdicionais(doc);
            nota.AppendChild(DadosAdicionais);



            doc.Save("C:\\Gransoft\\NOTATESTE.xml");
        }

        private XmlElement criaDadosEmitente(XmlDocument documento)
        {
            XmlElement emitente = documento.CreateElement(string.Empty, "Emitente", string.Empty);
            emitente.AppendChild(criaNode(documento,"RazaoSocial", this.RazaoSocial));
            emitente.AppendChild(criaNode(documento, "CNPJ", this.CNPJ));
            emitente.AppendChild(criaNode(documento, "DataEmissao", this.DataEmissao.ToShortDateString()));
            return emitente;
        }

        private XmlNode criaNode(XmlDocument documento,string nomeNode, string valorNode)
        {
            XmlNode node = documento.CreateElement(nomeNode);
            node.AppendChild(documento.CreateTextNode(valorNode));
            return node;

        }

        private XmlElement criaElemento(XmlDocument documento, string nomeelemento)
        {
            return documento.CreateElement(string.Empty, nomeelemento, string.Empty);
        }

        private XmlElement CriaItens(XmlDocument documento)
        {
            XmlElement elementoItens = criaElemento(documento, "Itens");
            int i = 1;
            foreach (ItemDaNota item in this.todosItens)
            {
                elementoItens.AppendChild(item.criaXML(documento, "Item",i));
                i++;
            }
            

            return elementoItens;
        }

        private XmlElement CriaDadosAdicionais(XmlDocument documento)
        {
            XmlElement dadosAdicionais = criaElemento(documento, "Dados_Adicionais");
            dadosAdicionais.AppendChild(criaNode(documento, "VrBruto", this.ValorBruto.ToString("N2")));
            dadosAdicionais.AppendChild(criaNode(documento, "Impostos", this.Impostos.ToString("N2")));
            dadosAdicionais.AppendChild(criaNode(documento, "Observacoes", this.Obervacoes));
            

            return dadosAdicionais;
        }
    }
}
