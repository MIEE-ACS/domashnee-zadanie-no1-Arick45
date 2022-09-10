using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите температуру в Цельсиях TC: ");
            float TC = float.Parse(Console.ReadLine());
            if (TC >= -273.15f)// проверка на существование такой температуры
            {
                float TF = TC * 9 / 5 + 32;//перевод в фаренгейты
                Console.WriteLine($"Температура в Фаренгейтах TF: {Math.Round(TF, 3)}F");
            }
            else
            {
                Console.WriteLine("Невозможное значение температуры в Цельсиях.Программа завершит работу");
            }
            Console.ReadKey(); // Ожидание ввода для того, что бы консоль не закрывалась.
        }
    }
}

