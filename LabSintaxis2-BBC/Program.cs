using System;

namespace LabSintaxis2Ej1yEj2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un texto: ");
            string inputTexto = Console.ReadLine();
            if (!inputTexto.Trim().Equals(""))
            {
                Console.Write("1-mayus \n2-minus \n3-cant caracteres \nElija opcion: ");
                ConsoleKeyInfo opc = Console.ReadKey();
                Console.Clear();
                switch (opc.Key)
                {
                    case ConsoleKey.D1:
                        {
                            string mayus = inputTexto.ToUpper();
                            Console.WriteLine(mayus);
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            string minus = inputTexto.ToLower();
                            Console.WriteLine(minus);
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            int cantLetras = inputTexto.Length;
                            Console.WriteLine(cantLetras);
                            break;
                        }
                    default:
                        break;
                }

            } else
            {
                Console.WriteLine("No ingresaste nada pa");
                Console.ReadKey();
            }
              
        }     
    }
}
