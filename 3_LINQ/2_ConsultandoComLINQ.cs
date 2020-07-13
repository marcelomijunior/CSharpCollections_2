using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LINQ
{
	partial class Program
	{
		static void ConsultandoSequenciaComLINQ()
        {
            List<Mes> meses = new List<Mes>
            {
                new Mes("Janeiro    ", 31),
                new Mes("Fevereiro  ", 28),
                new Mes("Março      ", 31),
                new Mes("Abril      ", 30),
                new Mes("Maio       ", 31),
                new Mes("Junho      ", 30),
                new Mes("Julho      ", 31),
                new Mes("Agosto     ", 31),
                new Mes("Setembro   ", 30),
                new Mes("Outubro    ",31),
                new Mes("Novembro   ", 30),
                new Mes("Dezembro   ", 31),
            };

            // Pegar o primeiro trimestre
            var consulta1 = meses.Take(3);

            foreach (var item in consulta1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // pegar os meses depois do primeiro trimestre
            var consulta2 = meses.Skip(3);

            foreach (var item in consulta2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // pegar os meses do terceiro trimestre
            var consulta3 = meses.Skip(6).Take(3);

            foreach (var item in consulta3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // pegar os meses até o mes que comece com a letra 's'
            var consulta4 = meses.TakeWhile(m => !m.Nome.StartsWith("S"));

            foreach (var item in consulta4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // pular os meses até que o mes comece com a letra 's'
            var consulta5 = meses.SkipWhile(m => !m.Nome.StartsWith("S"));

            foreach (var item in consulta5)
            {
                Console.WriteLine(item);
            }
        }
	}
}