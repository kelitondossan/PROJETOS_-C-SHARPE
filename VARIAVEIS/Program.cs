using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace VARIAVEIS
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração da variavel
            sbyte n = 20;
            var nome = "keliton";
            WriteLine("a variavel NJ tem "+ nome);
            WriteLine("N e um tipo " + nome.GetType());
            ReadKey();
        }
    }
}
