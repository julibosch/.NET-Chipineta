using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivineElNumero
{
    internal class Juego
    {
        private int _record;

        public Juego()
        {
            _record = int.MaxValue;
        }

        public void ComenzarJuego()
        {
            bool jugarPartida = true;
            Juego juego = new Juego();
            while (jugarPartida)
            {  
                int nMax = juego.PreguntarMaximo();
                Jugada jugada = new Jugada(nMax);
                JugadaConAyuda jugadaConAyuda = new JugadaConAyuda(nMax);
                bool adivinado = false;
                int intentos = 0;
                Console.WriteLine("ingresa un numero de intentos maximos");
                jugada.Intentos = int.Parse(Console.ReadLine());
                while (adivinado == false && intentos < jugada.Intentos)
                {
                    int num = juego.PreguntarNumero();
                    intentos++;
                    if (num == jugada.Numero)
                    {
                        adivinado = true;
                        Console.WriteLine("Felicidades, adivinaste el numero");
                        CompararRecord(intentos);
                    }
                    else {
                        Console.WriteLine("Numero incorrecto");
                        jugadaConAyuda.CompararConAyuda(jugada.Numero, num);
                    }
                }
                if (adivinado == false)
                {
                    Console.WriteLine("El numero era: {0}", jugada.Numero);

                }
                juego.Continuar();

            }

        }

        public void CompararRecord(int intentos)
        {
            if (intentos < _record) {
                _record = intentos;
                Console.WriteLine("¡Has establecido un nuevo récord de intentos!");
            }
        }

        public void Continuar()
        {
            Console.WriteLine("Desea Jugar otra partida?, S para continuar, N para terminar");
            string resp = Console.ReadLine();
            if (resp.ToUpper() != "S")
            {
                Console.WriteLine("Gracias por jugar");
                Environment.Exit(0);

            }
            else
            {
                Console.WriteLine("Comenzando otra partida");
            }
        }

        private int PreguntarMaximo()
        {
            Console.WriteLine("Ingrese un numero maximo de numeros que desea para el juego");
            int nMax = int.Parse(Console.ReadLine());
            return nMax;
        }

        private int PreguntarNumero()
        {
            Console.WriteLine("Intente adivinar el numero");
            int num = int.Parse(Console.ReadLine());
            return num;
        }
    }
}
