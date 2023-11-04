using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IbrayevAA.Sprint4.Task0.V25.Lib;

namespace Tyuiu.IbrayevAA.Sprint4.Task0.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Ибраев А. А. | ПКТБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Ибраев Абай Аскарович | ПКТБ-23-2                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму четных   *");
            Console.WriteLine("* элементов массива.  {1, 4, 2, 6, 4, 8, 6, 7, 8, 4}                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int[] numsArray = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };

            Console.WriteLine("Исходный массив: ");

            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            int sum;
            sum = ds.GetSumEvenArrEl(numsArray);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма четных элементов массива = " +sum);


            Console.ReadKey();
        }
    }
}
