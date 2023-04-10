using System;

namespace LabSintaxis3_BBC
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantIteraciones = 5;
            string[] arrayStrings = new string[cantIteraciones];

            Console.WriteLine("Ingrese 5 palabras");
            for (int i = 0; i < cantIteraciones; i++)
            {
                string palabra = Console.ReadLine();
                arrayStrings.SetValue(palabra, i);
            }

            Console.Clear();
            for (int j = cantIteraciones - 1; j >= 0; j--)
            {
                Console.WriteLine(arrayStrings[j]);
            }
        }
    }
}
