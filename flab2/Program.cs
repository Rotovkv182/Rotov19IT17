using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");    // кол-во элементов в массиве
            int n = Convert.ToInt32(Console.ReadLine()); // ввод с клавиатуры
            Random rand = new Random();    // Рандом
            int[] mas = new int[n];
            int imax = 0;
            int temp = 0;

            for (int i = 0; i < n; i++)
            {
                mas[i] = rand.Next(0, 1000); // цикл от 0 до 1000 рандомные числа
            }
            {
                Console.Write("Source massive: ");    // вывод исходного массива
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0} ", mas[i]);
                }
            }
            int max = mas[0];  // максимальный элемент
            for (int i = 1; i < n; ++i)
                if (mas[i] > max)
                {
                    max = mas[i];   
                    imax = i;
                }
            { 
                temp = mas[0];  // меняем местами
                mas[imax] = temp;
                mas[0] = max;
            }       
                       Console.WriteLine();
                       Console.WriteLine("Max Value: " + max); // вывод максимального значения
                       Console.Write("Sorted massive: "); //вывод сортированного массива
            for (var i = 0; i < mas.Length; i++) 
                Console.Write("{0} ", mas[i]);
                Console.ReadLine();

        }
    }
}
