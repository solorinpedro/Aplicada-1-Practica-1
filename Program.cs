using System;

namespace Ejercicio_Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cap1 cap1 = new Cap1();
            Cap2 cap2= new Cap2();
            Cap3 cap3 = new Cap3();

            int option;
            Console.WriteLine("Que capitulo desea ver:/1.Cap1 /2.Cap2 /3.Cap3");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    int n;
                    Console.WriteLine("Usted ha digitado la option 1 capitulo 1:");
                    Console.WriteLine("");
                    Console.WriteLine("Elija una Opcion /1.Ejercicio1 /5. Ejercicio5:");
                    n = int.Parse(Console.ReadLine());
                    if(n == 1)
                    {
                        cap1.ImprimirNombre();
                    }
                    if(n == 5)
                    {
                        cap1.Saludo();

                    }
                    else
                    {
                        Console.WriteLine("Opcion no valida!");
                    }
                    break;

                case 2:
                    int x;
                    Console.WriteLine("Usted ha digitado la option 2 capitulo 2:");
                    Console.WriteLine("");
                    Console.WriteLine("Elija una Opcion 1.Ejercicio1 /3.Ejercicio3 /4.Ejercicio4 /5.Ejercicio5");
                    x = int.Parse(Console.ReadLine());
                    if (x == 1)
                    {
                        cap2.HallarPerimetro();
                    }
                    if (x == 3)
                    {
                        cap2.TransformarGradosToRadianes();

                    }
                    if(x == 4)
                    {
                        cap2.CelsiusToFahrenheit();
                    }
                    if(x == 5)
                    {
                        cap2.ConveritirDivisa();
                    }
                    else
                    {
                        Console.WriteLine("Opcion Incorrecta");
                    }
                    break;

                case 3:
                    int y;
                    Console.WriteLine("Usted ha digitado la option 3 capitulo 3:");
                    Console.WriteLine("");
                    Console.WriteLine("Elija una Opcion /1.Ejercicio1 /4.Ejercicio4:");
                    y = int.Parse(Console.ReadLine());
                    if (y == 1)
                    {
                        cap3.Par();
                    }
                    if (y == 4)
                    {
                        cap3.DiaSemana();

                    }
                    else
                    {
                        Console.WriteLine("Opcion no valida!");
                    }
                    break;

            }
        }
    }
}
