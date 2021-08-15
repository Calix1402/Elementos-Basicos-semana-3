using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos_de_la_semana_3
{
    class Metodo_array
    {
        static void Main(string[] args)
        {

            // Se Declara y se llena lo que es el array
            string[] nombres = { "Ashely", "Alexi", "Walter", "Flor", };

            //Se calcula lo que es el array
            int length = nombres.Length;

            //Se utiliza el metodo sort para ordernar los nombres
            Array.Sort(nombres);

            //Se imprimen los nombres ordenados
            Array.Sort(nombres);

            Array.Reverse(nombres);
            Console.WriteLine("Array ordenado con el metodo Sort()");
            {



                Console.WriteLine(nombres[i]);


            }

            Console.ReadKey();
        }


    }
}
