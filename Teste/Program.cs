using System;
using System.Globalization;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x;
            x = new Triangulo();
            x.A = 20.25;  x.B = 20.15; x.C = 30.15;
            Console.WriteLine("Numeros dos lados dos triangulos: {0} , {1} e {2}.",x.A,x.B,x.C.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}
