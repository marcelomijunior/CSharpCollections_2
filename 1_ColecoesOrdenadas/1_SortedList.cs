using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ColecoesOrdenadas
{
	partial class Program
	{
		static void UsandoSortedList()
		{
            IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();

            alunos.Add("VT", new Aluno("Vanessa", 34672));
            alunos.Add("AL", new Aluno("Ana", 5617));
            alunos.Add("RN", new Aluno("Rafael", 17645));
            alunos.Add("WM", new Aluno("Wanderson", 11287));

            // imprimindo...
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            // removendo aluno
            alunos.Remove("AL");

            // adicionando novo aluno
            alunos.Add("MJ", new Aluno("Marcelo", 317189));

            Console.WriteLine();
            // imprimindo...
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            IDictionary<string, Aluno> sorted = new SortedList<string, Aluno>();

            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));

            Console.WriteLine();
            // imprimindo...
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
	}
}