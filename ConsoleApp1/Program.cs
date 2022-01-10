using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia = DateTime.Now.Day;// codigo para colocar data
            int mes = DateTime.Now.Month; // codigo para colocar mes
            int ano = DateTime.Now.Year; // codigo para colocar ano
            Console.WriteLine("Date"+ dia + "/" + mes + "/"  +ano);
            int hora = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            int seg = DateTime.Now.Second;

            Console.WriteLine("Hora "+ hora + ":" + min +  ":" + seg);


            Console.ReadKey();
        }
    }
}
