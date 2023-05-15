// See https://aka.ms/new-console-template for more information
using CrearPersona;


namespace pruebaPersona // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Andres", "Vombergar", 21, 233435353);

            Console.WriteLine(p.GetFullName());
            Console.WriteLine(p.GetAge());
            Console.WriteLine();
        }
    }
}



