using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Обобщенный класс Point
    class Point<T>
    {
        /// <summary>
        /// Поле X
        /// </summary>
        private T x;

        /// <summary>
        /// Поле Y
        /// </summary>
        private T y;

        /// <summary>
        /// Свойство для доступа к полю X
        /// </summary>
        public T X
        {
            get { return x; }
            set { x = value; }
        }

        /// <summary>
        /// Свойство для доступа к полю Y
        /// </summary>
        public T Y
        {
            get { return y; }
            set { y = value; }
        }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Point()
        {
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="x">точка x</param>
        /// <param name="y">точка y</param>
        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }



        /// <summary>
        /// Метод для вывода информации значений внутренних полей класса 
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"Координаты точки x: {x}, Координаты точки y: {y}");
        }


    }
}
