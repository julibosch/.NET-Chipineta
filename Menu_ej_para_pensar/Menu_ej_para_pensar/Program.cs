using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_ej_para_pensar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero de 1 al 9, 0 para salir");
            int a = int.Parse(Console.ReadLine());
            switch (a) { 

                case 1:
                    Ejercicio_1();
                    break;
                case 2:
                    Ejercicio_2();
                    break;
                case 3:
                    Ejercicio_3();
                    break;
                case 4:
                    Ejercicio_4();
                    break;
                case 5:
                    Ejercicio_5();
                    break;
                case 6:
                    Ejercicio_6();
                    break;
                case 7:
                    Ejercicio_7();
                    break;
                case 8:
                    Ejercicio_8();
                    break;
                case 9:
                    Ejercicio_9();
                    break;
                default:
                    Console.WriteLine("El numero ingresado es incorrecto");
                    break;


                       }
            Console.ReadKey();
        }



        static void Ejercicio_1()
        {
            int num1,num2;

            Console.WriteLine("Ingrese un numero para sumar");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero para sumar al numero anterior");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultado de la suma de " + num1 + " y "+ num2 + " es " +(num1+num2));
            Console.ReadKey();

        }

        static void Ejercicio_2()
        {

            Console.WriteLine("Ingrese un año para verificar si es bisiesto");
            int anio = int.Parse(Console.ReadLine());
            if ((anio % 4 == 0 && anio % 100 !=0))
            {
                Console.WriteLine("El año"+ anio + " es bisiesto");

            }
            else if(anio % 400 == 0)
            {
                Console.WriteLine("El año"+ anio + " es bisiesto");

            }
            else {
                Console.WriteLine(anio + " no es un año bisiesto");
            }

        }

        static void Ejercicio_3()
        {

            Console.WriteLine("Calculo de serie de Fibonacci");
            Console.WriteLine("Ingrese hasta cuantos numeros de la secuencia desea calcular");
            int n = int.Parse(Console.ReadLine());
            int[] serie = new int[n];
            int num1 = 0, num2 = 1;
            for (int i = 0; i < n; i++)
            {
                serie[i] = num1 + num2;
                if (num1 <= num2)
                {
                    num1 = serie[i];
                }
                else
                {
                    num2 = serie[i];
                }

            }
            Console.WriteLine("Los numeros de la serie son");
            for (int i = 0; i < n; i++) { 
            Console.Write(serie[i] + ",");
            }
        }


        static void Ejercicio_4()
        {
            Console.WriteLine("Los numeros pares del 1 al 100 son");
            for (int i = 0; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ",");

                }

            }

        }

        static void Ejercicio_5()
        {
            int band = 0;
            string[] meses = {"enero", "febrero", "marzo", "abril", "mayo", "junio", "julio",
                "agosto","septiembre","octubre","noviembre","diciembre" };
            Console.WriteLine("Ingrese el nombre de un mes para ver su numero");
            string mes = Console.ReadLine();
            mes = mes.ToLower();
            for (int i = 0; i < 12; i++)
            {
                if (mes == meses[i])
                {
                    Console.WriteLine("el numero de mes es " + (i+1));
                    band = 1;
                    break;
                }

            }
            if (band != 1)
            {
                Console.WriteLine("El mes ingresado es incorrecto");
            }



        }


        static void Ejercicio_6()
        {
            Console.WriteLine("Ingrese un numero para convertirlo en romano");
            int num = int.Parse(Console.ReadLine());
            if (num<1 || num>3999)
            {
                Console.WriteLine("El numero debe estar entre 1 y 3999");
                return;
            }

            /*se cargan arreglos para luego recorrerlos
             la posicion del arreglo es vacio ya que si el calculo de la division
            da 0 no devuelva ningun valor de esa unidad,decena,centena o miles*/
            string[] unidades = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] decenas = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] centenas = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] miles = { "", "M", "MM", "MMM" };

            string num_romano = "";

            /*Calculo de Miles*/
            num_romano += miles[num / 1000];
            num = num % 1000;

            /*Calculo de centenas*/
            num_romano += centenas[num / 100];
            num = num % 100;

            /*Calculo de decenas*/
            num_romano += decenas[num / 10];
            num = num % 10;

            /*Calculo de unidades*/
            num_romano += unidades[num];


            Console.WriteLine("El numero romano formado es " + num_romano);


        }

        static void Ejercicio_7()
        {
            Console.WriteLine("Ingrese un numero de primos que quiera buscar");
            int n = int.Parse(Console.ReadLine());
            int[] arr_primos = new int[n];
            int band = 0, i = 2;
            while (band < n)
            {
                if (Calcula_primo(i))
                {
                    arr_primos[band] = i;
                    band++;
                }
                i++;
            }

            for (int j = 0; j < n - 1; j++)
            {
                if (arr_primos[j] + 2 == arr_primos[j + 1])
                {
                    Console.WriteLine("Los numeros primos gemelos de los primos encontrados son: " +
                        arr_primos[j] + " y " + arr_primos[j + 1]);
                }
            }
        }

        static bool Calcula_primo(int x)
        {
            if (x <= 1)
            {
                return false;
            }
            for (int i = 2; i <= x / 2; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Ejercicio_8()
        {
            string clave = "1234";
            int intentos = 0;

            while (intentos < 4)
            {
                ++intentos;
                Console.WriteLine("Ingrese la clave");
                string clave_prueba = Console.ReadLine();
                /*no se hizo la validacion
                 clave_prueba = clave_prueba.ToLower() ya que 
                generalmente las contraseñas tienen en cuenta las mayusculas
                y las minusculas, igual en este caso la clave solo tiene
                numeros*/
                if (clave_prueba == clave)
                {
                    Console.WriteLine("La clave es correcta");
                    break;
                }
                else
                {
                    Console.WriteLine("La clave es incorrecta, intentelo otra vez");
                }

            }





        }

        static void Ejercicio_9()
        {
            Console.WriteLine("Ingrese las filas de la figura");
            int filas = int.Parse(Console.ReadLine());

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < filas - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



        }


    }
}
