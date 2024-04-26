using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calculator<T>
    {
       
        public dynamic a;
        public dynamic b;

        /// <summary>
        /// Метод для сложения
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="b1"></param>
        /// <returns></returns>
        public T Add(T a1, T b1)
        {
            dynamic a = a1;
            dynamic b = b1;
            return a + b;
        }

        /// <summary>
        /// Метод для вычитания
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="b1"></param>
        /// <returns></returns>
        public T Sub(T a1, T b1)
        {
            dynamic a = a1;
            dynamic b = b1;
            return a - b;
        }

        /// <summary>
        /// Метод для умножения
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="b1"></param>
        /// <returns></returns>
        public T Mul(T a1, T b1)
        {
            dynamic a = a1;
            dynamic b = b1;
            return a * b;
        }

        /// <summary>
        /// Метод для деления
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="b1"></param>
        /// <returns></returns>
        public T Div(T a1, T b1)
        {
            dynamic a = a1;
            dynamic b = b1;
            return a/b;
        }

        /// <summary>
        /// Метод, где на 0 делить нельзя
        /// </summary>
        /// <returns></returns>
        public dynamic ShhowInfo()
        {
            if(b==0)
            {
                Console.WriteLine("Делить на ноль нельзя");
            }
            return a / b;
        }



    }
}
