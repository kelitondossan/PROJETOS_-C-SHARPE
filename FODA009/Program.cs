using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ENTRADADEDADOS

{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Qual seu nome ");
            string nome = Console.ReadLine();
            SetCursorPosition(10, 2);
            Console.BackgroundColor = ConsoleColor.Blue;
            WriteLine("Prazer em te conhecer " + nome +  "!");
            ResetColor();
            Write("Digite sua idade ");
            int idade = int.Parse(Console.ReadLine());
            SetCursorPosition(5,5);
            Console.BackgroundColor = ConsoleColor.Blue;
            WriteLine("voce tem " + idade);

            ReadKey();


        }
    }
}
