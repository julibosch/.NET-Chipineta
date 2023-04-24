using System;

namespace Clases
{
    public class A
    {
        public string NombreInstancia { get; set; }
        public A() { NombreInstancia = "Instancia sin nombre"; }
        public A(string nombre) { NombreInstancia = nombre; }

        public string MostrarNombre() {
            return NombreInstancia;
        }

        public void M1()
        {
            Console.WriteLine("METODO M1");
        }

        public void M2()
        {
            Console.WriteLine("METODO M2");
        }

        public void M3()
        {
            Console.WriteLine("METODO M3");
        }
    }
}
