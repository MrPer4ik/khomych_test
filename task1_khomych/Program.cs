using System;

namespace task1
{
    class Program
    {
        static void Task1(string input)
        {
            int number = 0;
            try
            {
                number = Convert.ToInt32(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Введенная строка не является числом.");
            }

            if (number > 7)
                Console.WriteLine("Привет");
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();
            Task1(input);
            Console.ReadKey();
        }
    }
}
