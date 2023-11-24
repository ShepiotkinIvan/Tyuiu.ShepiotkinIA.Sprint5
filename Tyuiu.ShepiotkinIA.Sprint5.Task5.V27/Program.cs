using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.ShepiotkinIA.Sprint5.Task5.V27.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint5.Task5.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5| Выполнил :  Щепёткин И.А. | ИИПб-23-2";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #5                                                  *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                    *");
            Console.WriteLine("* Задание #5                                                 *");
            Console.WriteLine("* Вариант #27                                                *");
            Console.WriteLine("* Выполнил :  Щепёткин Иван Андреевич | ИИПб-23-2            *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Дан файл С:DataSprint5InPutDataFileTask5V27.txt            *");
            Console.WriteLine("* Найти среднее значение всех целых чисел в файле, которые   *");
            Console.WriteLine("* делятся на 5. олученный результат вывести на консоль.      *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                    *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine("**************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V27.txt";
            Console.WriteLine("данные находятся в файле: " + path);
            Console.WriteLine("File path: " + path);
            Console.WriteLine("data is: ");
            Console.WriteLine(String.Join(" ", File.ReadAllLines(path)));

            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");
            Console.WriteLine("**************************************************************");


            Console.WriteLine("среднее значение:");
            Console.WriteLine(ds.LoadFromDataFile(path));


            Console.ReadKey();
        }
    }
}
