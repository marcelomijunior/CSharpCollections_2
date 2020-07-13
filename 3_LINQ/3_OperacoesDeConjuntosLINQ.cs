using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LINQ
{
	partial class Program
	{
		static void OperacaoDeConjuntosUsandoLINQ()
        {
            string[] seq1 = { "janeiro", "fevereiro", "março" };
            string[] seq2 = { "fevereiro", "MARÇO", "abril" };
            Console.WriteLine($"1° sequência: {String.Join(",", seq1)}");
            Console.WriteLine($"2° sequência: {String.Join(",", seq2)}");

            Console.WriteLine();
            Console.WriteLine("Concatenando as duas sequências.");
            var consulta1 = seq1.Concat(seq2);
            foreach (var item in consulta1)
            {
                Console.WriteLine("- " + item);
            }
            Console.WriteLine();

            Console.WriteLine("União das duas sequências.");
            var consulta2 = seq1.Union(seq2);
            foreach (var item in consulta2)
            {
                Console.WriteLine("- " + item);
            }
            Console.WriteLine();

            Console.WriteLine("União das duas sequências com compador.");
            var consulta3 = seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase);
            foreach (var item in consulta3)
            {
                Console.WriteLine("- " + item);
            }
            Console.WriteLine();

            Console.WriteLine("Intersecção das sequências.");
            var consulta4 = seq1.Intersect(seq2);
            foreach (var item in consulta4)
            {
                Console.WriteLine("- " + item);
            }
            Console.WriteLine();

            Console.WriteLine("Exceto: elementos de seq1 que não estão em seq2.");
            var consulta5 = seq1.Except(seq2);
            foreach (var item in consulta5)
            {
                Console.WriteLine("- " + item);
            }
            Console.WriteLine();
        }
    }
}