// See https://aka.ms/new-console-template for more information
using System.Xml;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Presione una tecla para generar el archivo agendaxml.xml cn los datos de agenda.txt");
            Console.ReadKey();
            EscribirXML();
            Console.WriteLine("Archivo agendaxml.xml generado correctamente");
            Console.ReadKey();
            Console.WriteLine();
            leerXML();
            Console.ReadKey();
        }




        private static void EscribirXML()
        {
            XmlTextWriter escritorXML = new XmlTextWriter("agendaxml.xml", null);
            escritorXML.Formatting = Formatting.Indented;
            escritorXML.WriteStartDocument(true);
            escritorXML.WriteStartElement("DocumentElement");

            StreamReader lector = File.OpenText("agenda.txt");
            string linea;
            do

            {
                linea = lector.ReadLine();
                if (linea != null)
                {

                    string[] valores = linea.Split(";");
                    escritorXML.WriteStartElement("contactos");
                    escritorXML.WriteStartElement("nombre");
                    escritorXML.WriteValue(valores[0]);
                    escritorXML.WriteEndElement();
                    escritorXML.WriteStartElement("apellido");
                    escritorXML.WriteValue(valores[1]);
                    escritorXML.WriteEndElement();
                    escritorXML.WriteStartElement("email");
                    escritorXML.WriteValue(valores[2]);
                    escritorXML.WriteEndElement();
                    escritorXML.WriteStartElement("telefono");
                    escritorXML.WriteValue(valores[3]);
                    escritorXML.WriteEndElement();
                    escritorXML.WriteEndElement();

                }

            }
            while (linea != null);
            escritorXML.WriteEndElement();
            escritorXML.WriteEndDocument();
            escritorXML.Close();

            lector.Close();


        }

        private static void leerXML()
        {
            XmlTextReader lectorXML = new XmlTextReader("agendaxml.xml");

            string tagAnterior = "";
            while (lectorXML.Read())
            {
                if (lectorXML.NodeType == XmlNodeType.Element)
                {
                    tagAnterior = lectorXML.Name;

                }
                else if (lectorXML.NodeType == XmlNodeType.Text)
                {
                    Console.WriteLine(tagAnterior + ":" + lectorXML.Value);
                        
                }
            }
            lectorXML.Close();

        }



    }
}