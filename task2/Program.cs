using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Task2(string input)
        {
            if (input == "Вячеслав")
                Console.WriteLine("Привет, {0}", input);
            else
                Console.WriteLine("Нет такого имени");
        }

        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string input = Console.ReadLine();
            Task2(input);
            Console.ReadKey();
        }
    }
}
