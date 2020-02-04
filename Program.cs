using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLAB
{
    class Program
    {
        /* Task: R минимально, R кратно 21, произведение 2х различных элементов последовательности, 
           если такого числа нет вывести -1 */ 
        static void Main(string[] args)
        {
            Random rand = new Random();     //рандомные числа
            int R = -1;                     
            int check = 0;                  //проверка
            int enumer;                     //перебор

            for (int i = 0; i < 1000; i++)
            {
                enumer = rand.Next(0, 10000);  //внесение рандомных чмсел в переменную
                if (enumer < check)            //проверка на то, что результат цикла будет минимальный
                {
                    check = enumer;
                }
                int a = 0;
                int b = 0;
                if ((enumer % 7 == 0) && (a < enumer))
                {
                    a = enumer;
                }
                if ((enumer % 3 == 0) && (b < enumer))
                {
                    b = enumer;
                }
                if ((check < R) && (check % 21 == 0) && (check == (a * b)))    
                 /* Переменная проверяется на условие: check - минимально, кратно 21 и является произведением
                 2х различных элементов последовательности. 
                 Если check удовлетворяет условию, то присваевается R, если нет, R остается -1.*/
                {
                    R = check;
                }
            }
            Console.WriteLine(R);
        }
    }
}
 
