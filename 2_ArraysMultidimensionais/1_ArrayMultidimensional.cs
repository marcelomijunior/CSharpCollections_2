using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ArraysMultidimensionais
{
	partial class Program
	{
		static void TrabalhandoComArrayMultimensional()
        {
            string[,] resultados = new string[4, 3];
            //{
            //    {"Alemanha","Espanha","Itália",},
            //    {"Argentina","Holanda","França", },
            //    {"Holanda","Alemanha","Alemanha"}
            //};

            // resultados[classificação, copa do mundo]
            resultados[0, 0] = "Alemanha"; // campeão, copa 2014
            resultados[1, 0] = "Espanha"; // vice campeão, copa 2014
            resultados[2, 0] = "Itália"; // terceiro colocado, copa 2014
            resultados[3, 0] = "Brasil"; // quarto colocado, copa 2014

            resultados[0, 1] = "Argentina";
            resultados[1, 1] = "Holanda";
            resultados[2, 1] = "França";
            resultados[3, 1] = "Uruguai";

            resultados[0, 2] = "Holanda";
            resultados[1, 2] = "Alemanha";
            resultados[2, 2] = "Alemanha";
            resultados[3, 2] = "Portugal";


            //foreach (var selecao in resultados)
            //{
            //    Console.WriteLine(selecao);
            //}

            for (int copa = 0; copa <= resultados.GetUpperBound(1); copa++) // segunda dimensão (ínidice 1) = linha.
            {
                int ano = 2014 - copa * 4;
                Console.Write(ano.ToString().PadRight(15));
            }
            Console.WriteLine();

            for (int posicao = 0; posicao <= resultados.GetUpperBound(0); posicao++) // primeira dimensão (ínidice 0) = coluna.
            {
                for (int copa = 0; copa <= resultados.GetUpperBound(1); copa++) // segunda dimensão (ínidice 1) = linha.
                {
                    Console.Write(resultados[posicao, copa].PadRight(15));
                }
                Console.WriteLine();
            }

        }
    }
}