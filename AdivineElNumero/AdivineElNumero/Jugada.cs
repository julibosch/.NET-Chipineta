using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivineElNumero
{
    internal class Jugada
    {
        private int _adivino;
        private int _intentos;
        private int _numero;

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            int Numero = rnd.Next(maxNumero);
        }

        public int Adivino
        {
            get => _adivino;
            set => _adivino = value;
        }

        public int Intentos
        {
            get => _intentos;
            set => _intentos = value;
        }

        public int Numero
        {
            get => _numero;
            set => _numero = value;
        }

        public void Comparar()
        {
        }
    }
}
