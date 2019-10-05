using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            double f, c;

            Console.Write("Informe a Temperatura de ºF => ");
            f = double.Parse(Console.ReadLine());

            c = ((f - 32) * 5) / 9;

            Console.WriteLine("{0:N} ºF correspondem a {1:N} ºC", f, c);
            //Console.WriteLine( f + " ºF correspndem a " + c + " ºC");
            Console.ReadKey();
        }
    }
}
