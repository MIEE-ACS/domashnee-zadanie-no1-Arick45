using System;

namespace Домашка_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите температуру в Цельсиях TC: ");
            float TC= float.Parse(Console.ReadLine());
            if (TC >= -273.15f)// проверка на существование такой температуры
            {
                float TF = TC * 9 / 5 + 32;//перевод в фаренгейты
                Console.WriteLine($"Температура в Фаренгейтах TF: {TF:0.000}F");
            }
            else
            {
                Console.WriteLine("Невозможное значение температуры в Цельсиях.Программа завершит работу");
            }
        }
    }
}
