using System;

namespace Programa
{
    internal class Programas
    {
        static void Main(string[] args)
        {
            Circulo MiCirculo;

            MiCirculo = new Circulo();

            Console.WriteLine(MiCirculo.CalculoArea(7));
        }
    }

    class Circulo 
    {
        double pi = 3.1416;

        public double CalculoArea(int radio)
        {
            return pi * radio * radio;
        }
    }
} 