using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queries sencillos con arreglos y reflexion
            //con  numeros
            //Creacion del arreglo
            int[] numeros = { 1, 2, 3, 4, 5, 6,7,8 };

            //query

            IEnumerable<int> valores = from n in numeros
                                       where n > 2 && n < 6
                                       select n;

            //para mostar el resueltado, debemos recorrer el arreglo 

            foreach (int numer in valores)
            {
                Console.WriteLine(numer);

            }

            Console.WriteLine("----------");

            //con texto
            //Creacion del arreglo

            string[] nombres = {"tatiana peña", "maria gonzales", "juanpa peña", "jose buelvas","sebastian peña" };

            //Query
            IEnumerable<String> nom = from p in nombres
                                      where p.Contains("peña")
                                      orderby p
                                      select p;

            //mostrar resultados

            foreach (string nombre in nom)
            {
                Console.WriteLine(nombre);
            }

            Console.WriteLine("----------");

            Console.ReadKey();

        }
    }
}
