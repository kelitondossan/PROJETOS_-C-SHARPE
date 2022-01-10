using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
namespace TIPOSPRIMITIVOS

{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(" o tipo byte vai tanto ate " + byte.MinValue + " ate " +  byte.MaxValue);
            WriteLine(" o tipo sbyte vai tanto ate " + sbyte.MinValue + " ate " + sbyte.MaxValue);            
            WriteLine(" o tipo short vai tanto ate " + short.MinValue + " ate " + short.MaxValue);
            WriteLine(" o tipo int vai tanto ate " + int.MinValue + " ate " + int.MaxValue);
            WriteLine(" o tipo uint vai tanto ate " + uint.MinValue + " ate " + uint.MaxValue);
            WriteLine(" o tipo long vai tanto ate " + long.MinValue + " ate " + long.MaxValue);
            WriteLine(" o tipo ulong vai tanto ate " + ulong.MinValue + " ate " + ulong.MaxValue);
            WriteLine(" o tipo flaot vai tanto ate " + float.MinValue + " ate " + float.MaxValue);
            WriteLine(" o tipo double vai tanto ate " + double.MinValue + " ate " + double.MaxValue);
            WriteLine(" o tipo decimal vai tanto ate " + decimal.MinValue + " ate " + decimal.MaxValue);            



            ReadKey();
        }
    }
}
