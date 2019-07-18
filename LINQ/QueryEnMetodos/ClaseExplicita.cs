using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryEnMetodos
{
    class ClaseExplicita
    {
        //Creacion del arreglo


        private static string[] nombres = { "tatiana peña", "maria gonzales", "juanpa peña", "jose buelvas", "sebastian peña" };

        //por  ser statico el arreglo y privado debemos hacer el metodo static ya que no puede usarse de fomr implicita

        private static IEnumerable<string> EncontrarPares = from p in nombres
                                                       where p.Contains("peña")
                                                       orderby p
                                                       select p;

        //Trabajar la query en el metodo internamente

        public static IEnumerable<int> ObternerPares(){

            int[] Numeros = { 1, 5, 4, 6, 9, 5, 2 };
            IEnumerable<int> pares = from n in Numeros
                                     where n % 2 == 0
                                     select n;

            return pares;
        }

        //metodo que nos permite mostrar la informacion de la coleccion de encontrados

        public static IEnumerable<string> MostrarEncontrados(){

            return EncontrarPares;

        }

        //para mostrar resultados de la query de manera inmdiata

        public static int[] ObternerImpares()
        {
            int[] numeros = { 1, 5, 6, 9, 7, 3, 4, 5, 13, 15 };

            var impares = from nu in numeros
                          where nu%2 != 0
                          select nu;

            return impares.ToArray();

        }
    }
}
