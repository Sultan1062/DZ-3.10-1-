using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DZ4C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int start = int.Parse(Console.ReadLine());
            int i = start;
            if (i % 2 == 0)
            {
                Console.WriteLine("число четное");
            }
            else
            {
                Console.WriteLine("не четное");
            }
            Console.ReadKey();
        }
    }
}
