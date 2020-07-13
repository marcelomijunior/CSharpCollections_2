using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LINQ
{
	partial class Program
	{
		static void ConsultandoComLINQ()
        {
            // PROBLEMA: Obter nomes dos meses do ano que tme 31 dias, em maiúsculo e em ordem alfabética.
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

            //meses.Sort();

            //foreach (var mes in meses)
            //{
            //    if (mes.Dias == 31)
            //    {
            //        Console.WriteLine(mes.Nome.ToUpper());
            //    }
            //}

            // LINQ = Consulta Integrada à Linguagem

            // montagem da consulta
            IEnumerable<string> consulta = meses
                .Where(m => m.Dias == 31) // filtrando pelos meses com 31 dias
                .OrderBy(m => m.Nome) // ordenando pelo nome
                .Select(m => m.Nome.ToUpper()); // colocando o nome em caixa alta
            // Obs.: utilizando dessa forma não é necessário implementar em sua classe a interface IComparable e o método compareTo.

            // utilização da consulta criada
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
        }
    }
}