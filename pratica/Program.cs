using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pratica
{
    class Program
    {//PROGRAMA PRATICA EM COLOCar CORES NAS RESPOSTAS 
        static void Main(string[] args)
        {  //PRIMEIRA PARTE DO "MEU"
            Console.SetCursorPosition(10, 4);

            Console.BackgroundColor = ConsoleColor.Blue;//comando colocar cor no fundo das frases 
            Console.ForegroundColor = ConsoleColor.White;// comando coloca cor nas letras dos comandos ou progrmas 
            Thread.Sleep(1000);
            Console.Write(" MEU");

            Console.ResetColor();

            //SEGUNDA PARTE DO "BRASIL"
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);// cpomando thread.Sleep coloca tempo nos programas 
            Console.Write(" BRASIL");

            Console.ResetColor();

            // TRERCEIRA PARTE DO "BRASILEIRO"
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(3000);
            Console.Write("  BRASILEIRO");
            Console.ResetColor();
            
            
            Console.ReadKey();




        }
    }
}
