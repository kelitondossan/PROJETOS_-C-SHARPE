using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Random;
namespace estruturascondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();//Random class para repetição
            int n = gerador.Next(1,4 + 1);// next um item acrescentado para controla os numeros aleatorios  que foram adicionados 
            Console.WriteLine("Acabei de gerar umn numero " + n);
            Console.ReadKey();
        }
    }
}
