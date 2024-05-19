using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VlasovDS.Sprint5.Task6.V19.Lib;

namespace Tyuiu.VlasovDS.Sprint5.Task6.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Власов Д. С. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Власов Дмитрий Сергеевич | АСОиУб-23-3                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:DataSprint5InPutDataFileTask6V19.txt, в котором есть набор   *");
            Console.WriteLine("* символьных данных. Найти количество двузначных чисел в заданной строке. *");
            Console.WriteLine("* Полученный результат вывести на консоль.                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V19.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                         *");
            Console.WriteLine("***************************************************************************");
            
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Сумма целых элементов файла = " + res);
            Console.ReadKey();
        }
    }
}
