using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ColecoesOrdenadas
{
	partial class Program
	{
		static void UsandoSortedDictionary()
		{
            IDictionary<string, Aluno> sorted = new SortedDictionary<string, Aluno>();

            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));

            // imprimindo...
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Pressione a tecla enter para finalizar a execução...");
            Console.ReadLine();
        }
	}
}