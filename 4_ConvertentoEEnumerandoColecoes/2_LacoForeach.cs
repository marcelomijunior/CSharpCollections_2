using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConvertentoEEnumerandoColecoes
{
	partial class Program
	{
		static void LacoForeach()
        {
            //var meses = new List<string>
            var meses = new string[]
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };

            foreach (var item in meses)
            {
                meses[0] = meses[0].ToUpper();
                Console.WriteLine(item);
            }

            for (int i = 0; i < meses.Length; i++)
            {
                var mes = meses[i];
                // ...
            }
        }
	}
}
