using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLAB
{
    class Program
    {
        // Task: R минимально, R кратно 21 ,если такого числа нет вывести -1 
        static void Main(string[] args)
        {
            Random rand = new Random();     //случайные числа
            int[] mas = new int[1000];     //массив
            for (int i = 0; i < 1000; i++) //цикл от 0 до 10000 заполнен случайными числами
            {
                mas[i] = rand.Next(0, 10000);
                Console.WriteLine(mas[i]);
            }
            int R = mas[0];
            Console.WriteLine("Minimal Number is ");
            for (int i = 0; i < mas.Length; i++)     //Поиск минимального числа и присвоение его R
            {
                if (mas[i] < R)
                {
                    R = mas[i];
                }
            }
            Console.WriteLine(R);
            Console.WriteLine("Condition: ");     /* проверка на условие если "R кратно 21" и 
            является произведением двух случайных чисел массива если соответствует, 
            то выводится R, если нет, выводится -1 */
            int a = mas[new Random().Next(0, mas.Length)];
            int b = mas[new Random().Next(0, mas.Length)];
            int c = a * b;
            if ((R % 21 == 0) && (R == c && (a - b <= 8 || b - a <= 8 )))
            {
                Console.WriteLine(R);
            }
            else
            {
                Console.WriteLine("-1");
            }
        }
    }
}

