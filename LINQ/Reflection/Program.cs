using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {

            //Nos permite  Obtener informacion de un tipo , caracteristicas generales, campos, metodos, propiedades e interfaces
            //describen conjuntos, módulos y tipos. Se puede usar para crear dinámicamente una instancia de un tipo, vincular el
            //tipo a un objeto existente u obtener el tipo de un objeto existente e invocar sus métodos o acceder a sus campos y propiedades. 

            int i = 42;
            Type tipo = i.GetType();
            Console.WriteLine(tipo);

            Console.ReadKey();

        }
    }
}
