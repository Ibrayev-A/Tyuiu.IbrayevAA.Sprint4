﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IbrayevAA.Sprint4.Task6.V3.Lib;

namespace Tyuiu.IbrayevAA.Sprint4.Task6.V3
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
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Ибраев Абай Аскарович | ПКТБ-23-2                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Январь, Февраль, Март, Апрель, Май, Июнь,  *");
            Console.WriteLine("* Июнь, Июль, Август, Сентябрь, Октябрь, Ноябрь, Декабрь] используя класс *");
            Console.WriteLine("* Array подсчитайте количество элементов, длина которых меньше 6.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var month = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <=month.Length - 1; i++)
            {
                Console.WriteLine(month[i]);
            }




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            int nums = ds.Calculate(month);

            Console.WriteLine("Количество элементов, длина которых меньше 6 = " + nums);



            Console.ReadKey();
        }
    }
}
