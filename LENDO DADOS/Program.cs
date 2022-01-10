using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace LENDO_DADOS
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            WriteLine("Digite um numero : ");
            int.TryParse(Console.ReadLine(), out num);
            int k = num * 2;
            WriteLine("o dobro de " + num + " É " + k);
            ReadKey();
        }
    }
}
