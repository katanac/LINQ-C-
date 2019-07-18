 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ2DiferidoInmediato
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipos implicitos, ejecucion inferida e inmediata

            //arreglo de numeros

            int[] numeros = {1,2,3,5,6,4,8,7,1,5 };

            //Generacion de query y udo del implicito por medio de var

            var valores = from n in numeros
                          where n % 2 == 0
                          select n;

            Console.WriteLine("Recorrido del arreglo con linq");

            foreach (var num  in valores)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("   ");

            Console.WriteLine("ejecucion inmediata");
            //ejecuta la query en el momento exacto

            numeros[2] = 12;//Toma la modificacion

            //Arreglo
            int [] valoresarray = (from n in numeros
                                   where n % 2 == 0
                                   select n).ToArray<int>();

            //Lista

            List<int> valoresLista = (from n in numeros
                                      where n % 2 == 0
                                      select n).ToList<int>();

            //mostrar

            Console.WriteLine("Arreglo con linq");

            foreach (int numer in valoresarray)
            {
                Console.WriteLine(numer);
            }

            //modificacion del arreglo numeros 

            numeros[1] = 4;//No Toma la modificacion

            Console.WriteLine("Lista con linq");

            foreach (int listnum in valoresLista) {
                Console.WriteLine(listnum);
            }

            Console.ReadKey();
        }
    }
}
