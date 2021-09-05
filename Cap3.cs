using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Tarea1
{
    class Cap3
    {
        //Ejercicio#1
        public void Par()
        {
            int num;
            Console.WriteLine("Introduzca un numero:");
            num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("El numero ingresado es par:" + num);
            }
            else
            {
                Console.WriteLine("El numero ingresado es impar:" + num);
            }
        }

        //Ejercicio#2
        public void DiaSemana()
        {
            int opcion;
            Console.WriteLine("Introduzca un numero del 1 al 7");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Domingo!");
                    break;
                case 2:
                    Console.WriteLine("Lunes!");
                    break;
                case 3:
                    Console.WriteLine("Martes!");
                    break;
                case 4:
                    Console.WriteLine("Miercoles!");
                    break;
                case 5:
                    Console.WriteLine("Jueves!");
                    break;
                case 6:
                    Console.WriteLine("Viernes!");
                    break;
                case 7:
                    Console.WriteLine("Sabado!");
                    break;
                default:
                    Console.WriteLine("Esta Opcion esta fuera de los parametros");
                    break;
            }
        }
    }
}
