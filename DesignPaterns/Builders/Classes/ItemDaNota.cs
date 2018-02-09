using DesignPaterns.Stratedy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace DesignPaterns.Builders
{
    public  class ItemDaNota
    {


        public double CalculaTotalImposto()
        {
            try
            {
                return this.Impostos.Sum(i => i.Calcula(this.ValorItem));
            }
            catch (Exception)
            {

                return 0;
            }

           
        }

        public ItemDaNota(string descricao, double valorItem, List<Imposto> impostos)
        {
            Descricao = descricao;
            ValorItem = valorItem;
            Impostos = impostos;
        }


        public string Descricao { get; private set; }
        public double ValorItem { get; set; }
        public List<Imposto> Impostos { get; set; }

        public override string ToString()
        {
            return "Descrição:"+this.Descricao+" Valor: "+this.ValorItem+" VrImposto:"+this.CalculaTotalImposto();
        }

        public XmlElement criaXML(XmlDocument documento, String nomeElemento)
        {
            XmlElement xml = criaElemento(documento, nomeElemento);
            
            xml.AppendChild(criaNode(documento, "Descricao", this.Descricao));
            xml.AppendChild(criaNode(documento, "Valor", this.ValorItem.ToString("N2")));
            xml.AppendChild(criaNode(documento, "VrImposto", this.CalculaTotalImposto().ToString("N2")));
            return xml;
        }

        public XmlElement criaXML(XmlDocument documento, String nomeElemento, int id)
        {
            XmlElement xml = criaElemento(documento, nomeElemento,id);

            xml.AppendChild(criaNode(documento, "Descricao", this.Descricao));
            xml.AppendChild(criaNode(documento, "Valor", this.ValorItem.ToString("N2")));
            xml.AppendChild(criaNode(documento, "VrImposto", this.CalculaTotalImposto().ToString("N2")));
            return xml;
        }

        private XmlNode criaNode(XmlDocument documento, string nomeNode, string valorNode)
        {
            XmlNode node = documento.CreateElement(nomeNode);
            node.AppendChild(documento.CreateTextNode(valorNode));
            return node;

        }

        private XmlNode criaNodecriaNode(XmlDocument documento, string nomeNode, string valorNode, int id)
        {
            XmlNode node = documento.CreateElement(nomeNode);
            XmlAttribute productAttribute = documento.CreateAttribute("id");
            productAttribute.Value = id.ToString();
            node.Attributes.Append(productAttribute);
            node.AppendChild(documento.CreateTextNode(valorNode));
            return node;
        }

        private XmlElement criaElemento(XmlDocument documento, string nomeelemento)
        {
            return documento.CreateElement(string.Empty, nomeelemento, string.Empty);
        }

        private XmlElement criaElemento(XmlDocument documento, string nomeelemento,int id)
        {
            XmlElement elemento =   documento.CreateElement(string.Empty, nomeelemento, string.Empty);
            XmlAttribute attribute = documento.CreateAttribute("id");
            attribute.Value = id.ToString();
            elemento.Attributes.Append(attribute);
            return elemento;
        }

    }


    public class BuilderItemNota
    {
        public string Descricao { get; private set; }
        public double ValorItem { get; set; }
        public List<Imposto> Impostos { get; set; }


        public BuilderItemNota()
        {
            this.Impostos = new List<Imposto>();
        }


        public BuilderItemNota ComDescricao(string descricao) { this.Descricao = descricao; return this; }
        public BuilderItemNota ComValor(double valor) { this.ValorItem = valor; return this; }
        public BuilderItemNota ComImposto(Imposto imposto) { this.Impostos.Add(imposto); return this; }

        public ItemDaNota Constroi()
        {
            return new ItemDaNota(this.Descricao, this.ValorItem, this.Impostos);
        }



    }
}
