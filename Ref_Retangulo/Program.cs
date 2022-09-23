using System;
using System.Globalization;

namespace Ref_Retangulo {
    class Program {
        static void Main(string[] args) {

            Retangulo p = new Retangulo();

            Console.WriteLine("entre com a largura e altura do retângulo: ");

            p.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + p.Area().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Perimetro = " + p.Perimetro().ToString("F2",CultureInfo.InvariantCulture));

            Console.WriteLine("Diagonal = " + p.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
