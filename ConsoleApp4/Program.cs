using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instrngsinter
{
    class Program
    {
        static void Main(string[] args)
        {
            float sal = 0;
            Console.Write("Qual é seu sálario? ");
            float.TryParse(Console.ReadLine(), out sal);
            Console.WriteLine($"Você ganha {sal:c} por mês!") ;// :c sighnifoca dinheiro para colocar esse ($ ) atras da numeração
            Console.ReadKey();
        }
    }
}
