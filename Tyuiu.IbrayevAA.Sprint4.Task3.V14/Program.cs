using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IbrayevAA.Sprint4.Task3.V14.Lib;

namespace Tyuiu.IbrayevAA.Sprint4.Task3.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mrtx = new int[5, 5] { { 3, 2, 3, 3, 5 },
                                          { 2, 3, 3, 7, 3 },
                                          { 7, 5, 2, 7, 3 },
                                          { 4, 2, 7, 5, 2 },
                                          { 3, 5, 4, 2, 6 } };
            int rows = mrtx.GetUpperBound(0) + 1;
            int colums = mrtx.Length / rows;


            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Ибраев А. А. | ПКТБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Ибраев Абай Аскарович | ПКТБ-23-2                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 7.                          *");
            Console.WriteLine("* Найдите максимальный элемент в четвертой строке массива.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{mrtx[i, j]} \t");
                }
                Console.WriteLine();
            }





            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mrtx);

            Console.WriteLine("Максимальный элемент в четвертой строке массива = " + res);


            Console.ReadKey();
        }
    }
}
