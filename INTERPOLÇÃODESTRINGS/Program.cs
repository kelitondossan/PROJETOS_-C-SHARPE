using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERPOLÇÃODESTRINGS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual e seu nome ?");
            string nome = Console.ReadLine();
            Console.WriteLine($"Ola, {nome}! Tudo bem?");

            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;

            Console.WriteLine($"Hoje e {dia} do mês {mes} do ano de {ano}");
            Console.ReadKey();
        }
    }
}
