using System;

namespace Lab0201_ParaPensar3
{
    class Program
    {
        static void Main(string[] args)
        {
            // int numero1 = 1, numero2 = 1,suma = 0;
            int[] numeros = new int[20];
            numeros[0] = 1;
            numeros[1] = 1;
            for (int i = 2; i < 20; i++)
            {
                numeros[i] = numeros[i-1]  + numeros[i-2] ; 
                
            }
            foreach (int numero in numeros )
            {
                Console.WriteLine(numero);
            }
        }
    }
}
