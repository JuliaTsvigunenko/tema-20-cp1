using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Books<T>
    {

        /// <summary>
        /// Внутреннее поле названия книги
        /// </summary>
        private string name;
        /// <summary>
        /// Внутеннее поле цены книги
        /// </summary>
        private T price;


        /// <summary>
        /// Свойства доступа к внутренним полям
        /// </summary>
        public string Name { get; set; }
        public T Price { get; set; }

        /// <summary>
        /// Метод,который задает название книги
        /// </summary>
        /// <param name="name"></param>
        public void ShowInfo(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Метод, который задает цену книги
        /// </summary>
        /// <param name="price"></param>
        public void ShowInfo(T price)
        {
            Price = price;
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Название книги: {Name}\nЦена книги: {Price}");
        }


    }
}
