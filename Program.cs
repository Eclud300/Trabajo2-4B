using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("1.- sumar 2 numeros");
                Console.WriteLine("2.- restar 2 numeros");
                Console.WriteLine("3.- multiplicar 2 numeros");
                Console.WriteLine("4.- dividir 2 numeros");
                Console.WriteLine("5.- salir ");

                Console.Write("ingresa una opcion:");

                string entrada = Console.ReadLine();

                if (entrada != "")
                {
                    int opcion = Convert.ToInt32(entrada);




                    if (opcion == 1)
                    {
                        Console.Write("selecciona el primer numero");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("slecciona el segundo nmero");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("el resultado es: " + (num1 + num2));


                    }
                    else if (opcion == 2)
                    {
                        Console.Write("selecciona el primer numero");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("selecciona el segundo numero");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("el resultado es: " + (num1 - num2));



                    }
                    else if (opcion == 3)
                    {
                        Console.Write("selecciona el primer numero");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("selecciona el segundo numero");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("el resultado es:" + (num1 * num2));




                    }
                    else if (opcion == 4)
                    {
                        Console.Write("selecciona el primer numero");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("selecciona el segundo numero");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        if (num2 != 0)
                        {
                            Console.WriteLine("el resultado es: " + (num1 / (double)num2));
                        }

                        else
                        {
                            Console.WriteLine("no se puede dividir entre cero");



                        }
                    }
                    else if (opcion == 5)
                    {
                        Console.WriteLine("saliendo del menu");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("ingresa un numero");
                    }


                }
                Console.WriteLine();

            }

        }


    }

}