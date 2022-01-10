using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            WriteLine("BEM VINDO A PLATAFORMA DOBRO OU TRIPLO DE UM NUMERO");
            WriteLine("QUAL E SEU NOME ?  ");
            nome = ReadLine();
            WriteLine("vamos lá " + nome +  " dIGITE O NUMERO DESEJADO");

            WriteLine("Digite um numero ");
            int n = Convert.ToInt32 ( ReadLine());
            int d = n * 2;
            int t = n * 3;
            
            WriteLine("O dobro de " + n + " e " +d );
            WriteLine("O triplo de " + n + " e " + t);
            WriteLine(" De nada  " + nome);
            ReadKey();
        }
    }
}
