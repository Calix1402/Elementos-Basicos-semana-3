using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos_de_la_semana_3
{
    class arreglos
    {
        static void Main(string[] args)
        {

            //solicitar el nombre del estudiante 
            //solicitar la nota del estudiante 
            //IMPRIMR LA NOTA DE PROMEDIO N NOTAS 
            //IMPRIMIR EL NOMBRE DEL ESTUDIANTE CON LA NOTA MAS ALTA 

            int[] notas = new int[10];
            for (int i = 0; i < notas.Length; i++)
            {

                //solicitar las notas al usuario
                Console.WriteLine("Escriba la nota {0}:", i);
                notas[i] = Convert.ToInt32(Console.ReadLine());


                // recorrer el areglo de notas 
                for (int i = 0; i < notas.Length; i++)
                {



                    Console.WriteLine("nota{0}: {1}", i, notas[i]); // imprime los valores 

                }



            }
        }

    }
}
