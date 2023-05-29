using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivineElNumero
{
    internal class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int maxNumero) : base(maxNumero)
        {
        }

            public void CompararConAyuda(int numParaAdivinar, int numIngresado)
            {
            if (base.Comparar(numParaAdivinar, numIngresado) <= 5 && base.Comparar(numParaAdivinar, numIngresado) > 0)
            {
                Console.WriteLine("Ya casi lo adivinas, estas muy cerca");
            }
            else if (base.Comparar(numParaAdivinar, numIngresado) <= 20 && base.Comparar(numParaAdivinar, numIngresado) > 5)
            {

                Console.WriteLine("No estas lejos, sigue intentando!!");
            
            }

            else if (base.Comparar(numParaAdivinar, numIngresado) <= 100 && base.Comparar(numParaAdivinar, numIngresado) > 20)
            {

                Console.WriteLine("Estas demasiado lejos");

            }


            else if (base.Comparar(numParaAdivinar, numIngresado) <= int.MaxValue && base.Comparar(numParaAdivinar, numIngresado) > 100)
            {
                Console.WriteLine("Estas muy lejos");
            }


            }
            

            

    }

}

