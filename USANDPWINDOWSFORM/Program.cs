using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace USANDPWINDOWSFORM
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Qual seu nome ? ");
            string nome = ReadLine();
            WriteLine("prazer em te conhecer " + nome  + "!");
            ReadKey();
          
        }
    }
}