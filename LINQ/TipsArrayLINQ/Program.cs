using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsArrayLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tips de arrayList con LINQ por medio de OfType<>
            ArrayList Lista = new ArrayList();
            Lista.AddRange(new object [] {"asdasd",1,"trtryhyt",5,2.3,"rwerffsd" });

            //para obtener solo los enteros
            var enteros = Lista.OfType<int>();

            foreach (int n in enteros) {
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }
        
    }
}
