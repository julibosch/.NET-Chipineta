using System;

namespace Lab0201_ParaPensar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un año ");
            String year = Console.ReadLine();

            int anio = Convert.ToInt32(year);

            if (anio % 4 == 0)
            {
                if (anio%100 == 0)
                {
                    if (anio % 400 == 0) Console.WriteLine("El año " + anio + " es biciesto");
                    else Console.WriteLine("El año " + anio + " NO es biciesto");
                }
                else Console.WriteLine("El año " + anio + " es biciesto");
            }
            else Console.WriteLine("El año " + anio + " NO es biciesto");

        }
    }
}
