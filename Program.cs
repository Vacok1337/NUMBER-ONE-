using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Вы внесли = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Под процентную ставку = ");
            double b = double.Parse(Console.ReadLine());
            double c = a + (b * (a / 100));
            Console.WriteLine("Через год вы получите " + c + "руб.");
            Console.Read();
        }
    }
}