using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueryClases
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> Estudiantes = new List<Estudiante>
            {
                new Estudiante( 1, "tatiana", 22, "umb", 4),
                new Estudiante( 2, "juan", 20, "kl", 2 ),
                new Estudiante( 3, "daniela", 19, "dist", 5 ),
                new Estudiante( 4, "julian", 19, "kl", 2 ),
                new Estudiante( 5, "steffanie", 23, "dist", 1 )

            };

            var resprobados = from e in Estudiantes
                              where e.Nota < 3
                              select e;

            foreach (Estudiante reprueba in resprobados) {

                Console.WriteLine(reprueba);
            }

            Console.ReadKey();
        }
    }
}
