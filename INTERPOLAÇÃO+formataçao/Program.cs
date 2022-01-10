using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERPOLAÇÃO_formataçao
{
    class Program
    {
        static void Main(string[] args)
        {



            string nome = "keliton";
            float sal = 350.0000000000f;
            int idade = 22;
            Console.WriteLine($"o {nome,10} tem {idade, -5:D3} ganha {sal,10:c} por mês.");// Aqui e uma variavél string interpolada  com $ e formatada com ":c"
            int num = 13;
            Console.WriteLine($"O numero foi {num:X}");// A letra X significa hexadecimal e pode substituir numeros por letras
            float val = 2939.920f;
            Console.WriteLine($"O valor foi {val:E}.:");// usando o "E" para  colocar numero ciêntifico
            Console.ReadKey();




        }
    }
}
