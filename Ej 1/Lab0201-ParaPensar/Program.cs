using System;

namespace Lab0201_ParaPensar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número: ");
            string input1 = Console.ReadLine();

            Console.Write("Ingrese el segundo número: ");
            string input2 = Console.ReadLine();

            int numero1 = Convert.ToInt32(input1);
            int numero2 = Convert.ToInt32(input2);

            int suma = numero1 + numero2;

            Console.WriteLine("/n La suma entre " + numero1 + " y el numero " + numero2 + " es igual a: " + suma);
            //Console.WriteLine
        }
    }
}
