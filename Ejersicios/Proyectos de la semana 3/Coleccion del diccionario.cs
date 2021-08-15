using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos_de_la_semana_3
{
    class Coleccion_del_diccionario
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> mydictionary = new Dictionary<string, string>();

            mydictionary.Add("18", "Alexi Calix ");
            mydictionary.Add("16", "Ashley Calix ");
            mydictionary.Add("34", "Flor Torres");
            mydictionary.Add("35", "Walter Calix ");


            Console.WriteLine(mydictionary["34"]);
            Console.ReadKey();




        }

    }
}
