using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConvertentoEEnumerandoColecoes
{
	partial class Program
	{
		static void UsandoCovariancia()
        {
            Console.WriteLine("String para Object.");
            string titulo = "meses";
            object obj = titulo;
            Console.WriteLine(obj);

            Console.WriteLine("Conversão de uma lista de string para lista de object.");
            IList<string> listaMeses = new List<string>
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };
            //IList<object> listaObj = listaMeses;
            Console.WriteLine();

            Console.WriteLine("string[] para object[].");
            string[] arrayMeses = new string[]
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };
            object[] arrayObj = arrayMeses; // isso se chama COVARIÂNCIA!
            //Console.WriteLine(String.Join(",", arrayObj));
            foreach (var mes in arrayObj)
            {
                Console.WriteLine(mes);
            }

            arrayObj[0] = "primeiro mês";
            Console.WriteLine(arrayObj[0]);
            Console.WriteLine();

            //arrayObj[0] = 12345;
            //Console.WriteLine(arrayObj[0]);
            //Console.WriteLine();

            Console.WriteLine("Transformar IList<string> para uma IEnumerable<object>.");
            IEnumerable<object> enumObj = listaMeses; // isso é uma COVARIÂNCIA também!
            foreach (var item in enumObj)
            {
                Console.WriteLine(item);
            }
        }
    }
}