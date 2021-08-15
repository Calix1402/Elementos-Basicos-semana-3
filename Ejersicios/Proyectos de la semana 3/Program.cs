using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos_de_la_semana_3
{
    class Program
    {
        static void Main(string[] args)
        {


            //loops
            loopwhile();
            Console.ReadKey();

        }

        //while
        //evalua la condicion y ejecuta las instrucciones 
        //si la condicion es verdadera 

        public static void loopwhile()
        {

            int[] nums = new int[3]; // crear un arreglo 

            // llenar areglo
            nums[0] = 4;
            nums[1] = 22;
            nums[2] = 8;

            //imprimir los numeros utilizando while 
            int i = 0, idw = 0;
            Console.WriteLine("IMPRIMIENDO CON WHILE");
            while (i < nums.Length)
            {

                Console.WriteLine("Indice {0}: {1}", i, nums[i]);
                i++;
            }

            //imprimir con ciclo for
            //se comprueba la condicion primero y luego se ejecuta si la condicion es verdadera 
            Console.WriteLine("IMPRIMIENDO CON FOR");
            for (int inc = 0; inc < nums.Length; inc++)
            {



                Console.WriteLine("Indice {0}: {1}", inc, nums[inc]);




            }

        }
    }
}
