using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Books<int> books1 = new Books<int>();
            books1.ShowInfo("Мастер и Маргарита");
            books1.ShowInfo(500);
            Console.WriteLine(books1.ToString());

            Books<string> books2 = new Books<string>();
            books2.ShowInfo("Горе от ума");
            books2.ShowInfo((string)"700");
            Console.WriteLine(books2.ToString());

            Console.ReadKey();

        }
    }
}
