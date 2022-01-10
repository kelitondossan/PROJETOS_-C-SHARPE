using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace colocando_em_pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            const string escola = "aluno";
            const float PI = 3.1415f;

            SetCursorPosition(10, 5);
            ConsoleColor SetForegoundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;

            WriteLine(" eu estudo no " + escola);
            ResetColor();
            WriteLine("o valor de PI" + PI);
            
            WriteLine("O valor oficial de PI " + Math.PI);
            WriteLine("O tipo da PI em Math é " + Math.PI.GetType());
            ReadKey();
           
        }
    }
}
