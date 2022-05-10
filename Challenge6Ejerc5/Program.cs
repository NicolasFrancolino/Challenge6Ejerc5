using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6Ejerc5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilas<String> pilas = new Pilas<String>();
            pilas.Apilar("Hola");
            pilas.Apilar("Soy");
            pilas.Apilar("Nicolas");
            pilas.MostrarPila();

            Pilas<double> pilas1 = new Pilas<double>();
            pilas1.Apilar(3);
            pilas1.Apilar(4.6);
            pilas1.Apilar(21);
            pilas1.MostrarPila();
            Console.WriteLine();
            pilas1.Desapilar();
            pilas1.MostrarPila();
            Console.ReadKey();
        }
    }
}
