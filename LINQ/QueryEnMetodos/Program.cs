using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryEnMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("--------numeros pares--------------------");

            IEnumerable<int> pares = ClaseExplicita.ObternerPares();

            foreach (int EsPar in pares) {
                Console.WriteLine(EsPar);
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("----------------Nombres------------------");

            IEnumerable<String> nom = ClaseExplicita.MostrarEncontrados();
            foreach (string SeEncontro in nom) {
                Console.WriteLine(SeEncontro);
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("--------numeros Impares------------------");

            IEnumerable<int> impar = ClaseExplicita.ObternerImpares();
            foreach (int imp in impar)
            {
                Console.WriteLine(imp);
            }

            Console.ReadKey();

        }
    }
}
