using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ArraysMultidimensionais
{
	partial class Program
	{
		static void TrabalhandoComJaggedArrays()
        {
            // JAGGED ARRAY = array  denteado = array serrilhado

            string[][] familias = new string[3][];
            //{
            //    { "Fred", "Wilma", "Pedrita" },
            //    { "Homer", "Marge", "Lisa", "Bart", "Maggie" },
            //    { "Florinda", "Kiko" }
            //};
            familias[0] = new string[] { "Fred", "Wilma", "Pedrita" };
            familias[1] = new string[] { "Homer", "Marge", "Lisa", "Bart", "Maggie" };
            familias[2] = new string[] { "Florinda", "Kiko" };

            foreach (var familia in familias)
            {
                Console.WriteLine(String.Join(",", familia));
            }

            //for (int i = 0; i < familias.Length; i++)
            //{
            //    for (int j = 0; j < familias[i].Length; j++)
            //    {
            //        Console.WriteLine(familias[i][j]);
            //    }
            //    Console.WriteLine();
            //}

        }
    }
}