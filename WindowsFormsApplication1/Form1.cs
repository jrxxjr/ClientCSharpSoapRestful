using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;


namespace TestSoapRestForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnRest_Click(object sender, EventArgs e)
        {
            try
            {
                string parametro1 = "A";
                string parametro2 = "B";
                string urlRest = "http://192.168.1.30:8080/test/testejavarest/" + parametro1 + "/" + parametro2;
                WebRequest req = WebRequest.Create(@urlRest);
                req.Method = "GET";
                HttpWebResponse resp = req.GetResponse() as HttpWebResponse;

                if (resp.StatusCode == HttpStatusCode.OK)
                {
                    using (Stream respStream = resp.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(respStream, Encoding.UTF8);
                        XmlDocument xml = new XmlDocument();
                        XmlReader xmlReader = XmlReader.Create(reader);
                        xml.Load(xmlReader);
                    
                        XmlNode refNode = xml.SelectSingleNode("Cadastro");
                        XmlNode id = refNode.SelectSingleNode("cadastroId");
                        XmlNode quantidade = refNode.SelectSingleNode("quantidade");

                        StringBuilder output = new StringBuilder();
                        output.Append("Id:" + id.InnerText);
                        output.Append("\r\n");
                        output.Append("Quantidade:" + quantidade.InnerText);
                        output.Append("\r\n");
                    
                        richTextRest.Text = output.ToString();
                    }
                }
                else
                {
                    richTextSoap.Text = string.Format("Codigo Estatus: {0}, Descricao Estatus: {1}", resp.StatusCode, resp.StatusDescription);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro:", ex);
            }
        }

        private void btnSoap_Click(object sender, EventArgs e)
        {
            try
            {
                wsServico.TesteJavaEndpointClient proxy = new wsServico.TesteJavaEndpointClient();
                wsServico.cadastroTo result = proxy.returnServico("C", "D");
                StringBuilder output = new StringBuilder();
                output.Append("Id:" + result.cadastroId.ToString());
                output.Append("\r\n");
                output.Append("Quantidade:" + result.quantidade.ToString());
                output.Append("\r\n");

                richTextSoap.Text = output.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro:", ex);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            richTextRest.Text = "";
            richTextSoap.Text = "";
        }
                
    }
}
