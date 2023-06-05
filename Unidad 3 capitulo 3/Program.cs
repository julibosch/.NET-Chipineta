using System;
using System.Collections;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList Ciudades = new ArrayList();

            Ciudades.Add(new Ciudad("Buenos Aires", "1000"));
            Ciudades.Add(new Ciudad("Córdoba", "5000"));
            Ciudades.Add(new Ciudad("Rosario", "2000"));
            Ciudades.Add(new Ciudad("Mendoza", "5500"));
            Ciudades.Add(new Ciudad("Salta", "4400"));
            Ciudades.Add(new Ciudad("La Plata", "1900"));
            Ciudades.Add(new Ciudad("San Miguel de Tucumán", "4000"));
            Ciudades.Add(new Ciudad("Mar del Plata", "B600"));
            Ciudades.Add(new Ciudad("Santa Fe", "3000"));
            Ciudades.Add(new Ciudad("San Juan", "5400"));

            List<Ciudad> CiudadesLista = new List<Ciudad>(Ciudades.Cast<Ciudad>());

            Console.WriteLine("ingrese tres letras de la ciudad que quiera obtener su codigo");
            string ciu = Console.ReadLine();

            var codigosEncontrados = from ciudad in CiudadesLista
                                     where ciudad.Nombre.Contains(ciu, StringComparison.OrdinalIgnoreCase)
                                     select new { Nombre = ciudad.Nombre, Codigo = ciudad.Codigo };



            Console.WriteLine("Los codigos postales de las ciudades encontradas son");
            foreach (var ciudad in codigosEncontrados)
            {
                Console.Write(ciudad.Nombre);
                Console.Write("  ");
                Console.WriteLine(ciudad.Codigo);

            }
            Console.ReadKey();

        }






    }

    class Ciudad
    {

        public String Nombre { set; get; }
        public String Codigo { set; get; }

        public Ciudad(String nombre, String codigo)
        {
            Nombre = nombre;
            Codigo = codigo;

        }



    }

      
}
