using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Task3(string input)
        {
            string[] str_numbers = input.Split(' ');
            for (int i=0; i<str_numbers.Length; i++)
            {
                int number = Convert.ToInt32(str_numbers[i]);
                if (number % 3 == 0)
                    Console.Write("{0} ", number);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите числовой массив (через пробел): ");
            string input = Console.ReadLine();
            Task3(input);
            Console.ReadKey();
        }
    }
}
