using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CONVERSÃODEAUXILIARES

{
    class Program
    {
        static void Main(string[] args)
        {
            // a conversao IMPLICITA int > float
            /* int a = 8;
             float b = a;
             WriteLine("O valor de "  + a  + "do tipo"  +  a.GetType());
             WriteLine("O valor de b e " + b +  "do tipo" + b.GetType());*/


            //CONVERSÃO EXPLICITA FLOAT > INT
            // CONVERSÃO POR CLASSES AUXILIARES
            /* float a = 8.76f;
           int b = (int)a; */


            //CONVERSÃO POR CLASSES AUXILIARES
            
            float a = 8.799996f;
            int b = Convert.ToInt16(a);

            WriteLine("O valor de " + a + " do tipo 5" + a.GetType());
            WriteLine("O valor de b e " + b + " do tipo " + b.GetType());




            ReadKey();

        }
    }
}
