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

            Calculator<int> a = new Calculator<int>();
            Console.WriteLine($"Сложение: {a.Add(18, 2)}");
            Console.WriteLine($"Вычитание: {a.Sub(15, 10)}");
            Console.WriteLine($"Умножение: {a.Mul(12, 12)}");
            Console.WriteLine($"Деление: {a.Div(6, 2)}");

            Calculator<double> v = new Calculator<double>();
            Console.WriteLine($"Сложение: {v.Add(11.5, 13.5)}");
            Console.WriteLine($"Вычитание: {v.Sub(15.1, 10.1)}");
            Console.WriteLine($"Умножение: { v.Mul(1.2,2.3)}");
            Console.WriteLine($"Вычитание: {v.Div(6.4, 2.4)}");

            Console.ReadKey();









        }
    }
}
