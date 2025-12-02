using System;

namespace Actividad2U3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema");
            Console.WriteLine("---------------------");
            Console.WriteLine("Por favor seleccione una opción del menú");
            Console.WriteLine("1.- Calcular siglos");
            Console.WriteLine("2.- Codificar mensaje");
            Console.WriteLine("3.- Salir");

            int a;
            string b;
            int op = 0;
            op = Convert.ToInt32(Console.ReadLine());

            switch(op)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("Calcular el siglo");
                    Console.WriteLine("Ingrese el año: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a > 2021 || a < 1000)
                    {
                        Console.WriteLine("El año ingresado esta fuera de rango");
                    }

                    if(a >= 1001  && a <= 1100)
                    {
                        Console.WriteLine("El año pertenece al siglo XI");
                    }
                    else if (a >= 1101 && a <= 1200)
                    {
                        Console.WriteLine("El año pertenece al siglo XII");
                    }
                    else if (a >= 1201 && a <= 1300)
                    {
                        Console.WriteLine("El año pertenece al siglo XIII");
                    }
                    else if (a >= 1301 && a <= 1400)
                    {
                        Console.WriteLine("El año pertenece al siglo XIV");
                    }
                    else if (a >= 1401 && a <= 1500)
                    {
                        Console.WriteLine("El año pertenece al siglo XV");
                    }
                    else if (a >= 1501 && a <= 1600)
                    {
                        Console.WriteLine("El año pertenece al siglo XVI");
                    }
                    else if (a >= 1601 && a <= 1700)
                    {
                        Console.WriteLine("El año pertenece al siglo XVII");
                    }
                    else if (a >= 1701 && a <= 1800)
                    {
                        Console.WriteLine("El año pertenece al siglo XVIII");
                    }
                    else if (a >= 1801 && a <= 1900)
                    {
                        Console.WriteLine("El año pertenece al siglo XIX");
                    }
                    else if (a >= 1901 && a <= 2000)
                    {
                        Console.WriteLine("El año pertenece al siglo XX");
                    }
                    else if (a >= 2001 && a <= 2021)
                    {
                        Console.WriteLine("El año pertenece al siglo XXI");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Precione una tecla para salir");
                    break;

                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("Codificar un mensaje");
                    Console.WriteLine("Escriba su mensaje: ");
                    b = Console.ReadLine();
                    string c = b.Replace("a", "4").Replace("e","3").Replace("i","1").Replace("o","0").Replace("s","5");
                    Console.WriteLine("Mensaje codificado: " +c);
                    Console.WriteLine("");
                    Console.WriteLine("Precione una tecla para salir");
                    break;

                case 3:
                    Console.WriteLine("Hasta luego");
                    break;
                default:
                    Console.WriteLine("Seleccione una opción correcta");
                    break;
            }
            Console.ReadKey();
        }
    }
}
