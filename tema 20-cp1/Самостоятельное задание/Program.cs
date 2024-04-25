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
            // Создание экземпляра с типом int
            Point<int> intPoint = new Point<int>(11, 23);
            intPoint.Display();

            // Создание экземпляра с типом double
            Point<double> doublePoint = new Point<double>(7.9, 1.2);
            doublePoint.Display();

            Console.ReadKey();
        }
    }
}
