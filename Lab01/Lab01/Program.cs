using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            escribir();
            Console.WriteLine("Presione una tecla para generar el archivo agendaxml.xml cn los datos de agenda.txt");
            Console.ReadKey();
            EscribirXML();
            Console.WriteLine("Archivo agendaxml.xml generado correctamente");
            Console.ReadKey();
            Console.WriteLine();
            leerXML();
            Console.ReadKey();
        }

        private static void leer()
        {
            StreamReader Lector = File.OpenText("Agenda.txt");
            string linea;
            Console.WriteLine("Nombre\tApellido\te-mail\t\t\tTelefono");
            do
            {
                linea = Lector.ReadLine();
                if (linea != null)
                {
                    string[] valores = linea.Split(";");
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", valores[0], valores[1], valores[2], valores[3]);
                }

            }
            while (linea != null);
            Lector.Close();
        }


        private static void escribir()
        {
            StreamWriter Escritor = File.AppendText("Agenda.txt");
            Console.WriteLine("Ingrese nuevo contacto");
            string rta = "S";
                while (rta == "S")
                    {
                        Console.Write("Ingrese nombre");
                        string nombre = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Ingrese apellido");
                        string apellido = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Ingrese email");
                        string email = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Ingrese telefono");
                        string telefono = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Escritor.WriteLine(nombre + ";" + apellido + ";" + email + ";" + telefono);

                        Console.Write("¿Desea ingresar otro contacto? (S/N)");
                        rta = Console.ReadLine();
                    }   
                    Escritor.Close();

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
