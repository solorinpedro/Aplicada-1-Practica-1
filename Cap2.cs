using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Tarea1
{
    class Cap2
    {
       //Ejercicio#1
        public void HallarPerimetro()
        {
            int L;
            int Perimetro;

            Console.WriteLine("Digite los lados que tiene el poligono:");
            L = int.Parse(Console.ReadLine());
            Perimetro = L * L;
            Console.WriteLine("El perimetro es:" + Perimetro);
          
        }
        //Ejercicio #3
        public void TransformarGradosToRadianes()
        {
            float grados;
            double Pi = 3.14;
            double radianes;

            Console.WriteLine("Introduzca el valor de los grados a convertir");
            grados = float.Parse(Console.ReadLine());

            radianes = (Pi * grados) / 180;
            Console.WriteLine("El valor en radianes es:" + radianes);
        }

        //#Ejercicio4
        public void CelsiusToFahrenheit()
        {
            double celsius;
            double fahrenheit;

            Console.WriteLine("Introduzca el valor de celsius a covertir a fahrenheit:");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("El valor de su temperatura en fahrenheit es:" + fahrenheit);
        }

        //#Ejercicio5 
        public void ConveritirDivisa()
        {
            double valorDolar = 0.84;
            double  ValorEuro = 1.18;
            double  dolares;
            double euro;

            Console.WriteLine("Introduzca la cantida de dolar a convertir:");
            dolares = float.Parse(Console.ReadLine());

            dolares = dolares / ValorEuro;
            euro = dolares / valorDolar;

            Console.WriteLine("El valor de sus divisas es:" + dolares);
            Console.WriteLine("En euro es: " + euro);

        }
    }
}
