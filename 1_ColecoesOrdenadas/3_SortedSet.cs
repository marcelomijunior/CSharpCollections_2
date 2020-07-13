using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ColecoesOrdenadas
{
    partial class Program
    {
        static void UsandoSortedSet()
        {
            // conjunto de alunos:
            ISet<string> alunos = new SortedSet<string>(new CompadadorMinusculo())
            {
                "Vanessa Tonini",
                "Ana Losnak",
                "Rafael Nercessian",
                "Priscila Stuani"
            };

            // adicionar novos alunos
            alunos.Add("Marcelo Junior");
            alunos.Add("Fabio Gushiken");
            alunos.Add("Fabio Gushiken");
            alunos.Add("FABIO GUSHIKEN");

            // imprimindo...
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            ISet<string> outroConjunto = new HashSet<string>();

            // este conjunto é um subconjunto de alunos? IsSubsetOf
            alunos.IsSubsetOf(outroConjunto);

            // este conjunto é um superconjunto de alunos? IsSupersetOf
            alunos.IsSupersetOf(outroConjunto);

            // os conjunto contém os mesmos elementos? SetEquals
            alunos.SetEquals(outroConjunto);

            // subtrai os elementos da outra coleção que também estão neste conjunto. ExceptWith
            alunos.ExceptWith(outroConjunto);

            // intersecção dos conjuntos. IntersectWith
            alunos.IntersectWith(outroConjunto);

            // somente em um ou outro conjunto. SymmetricExceptWith
            alunos.SymmetricExceptWith(outroConjunto);

            // união dos elementos dos dois conjuntos. UnionWith
            alunos.UnionWith(outroConjunto);

            Console.WriteLine();
            Console.WriteLine("Pressione a tecla enter para finalizar a execução...");
            Console.ReadLine();
        }
    }

    internal class CompadadorMinusculo : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return String.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}