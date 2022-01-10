using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace TEXTE6
{
    class Program
    {
        
        static void Main(string[] args)
        {

            SetCursorPosition(15, 5);// mudar a posição da frase criada 
            ConsoleColor SetForegoundeColor = ConsoleColor.Black;//colocar cor nas letras 
            Console.BackgroundColor = ConsoleColor.Red;// colocar cor no fundo das letras 
            WriteLine("Olá, querido(A) estudonauta!");
            Console.ResetColor();// reseta a cor da primeira string para quabndo for criara outra string nao mudar a tela toda do console
            ReadKey();
            Clear();          
            SetCursorPosition(9, 12);
            ConsoleColor SetForegounderColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Green;
            WriteLine("Tudo bem com você! digite seu nome a seguir");
            Console.ResetColor();
            ReadKey();
            
        }
    }
}
