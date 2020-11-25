using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            showData();

        }

        static public void showData()
        {
            var chekSpell = false;
            while (chekSpell==false)
            {
                Console.Write("Input date: ");
                chekSpell = DateTime.TryParse(Console.ReadLine(), out DateTime userInput);
                if (chekSpell)
                {
                    Console.WriteLine($"Your day:{userInput.DayOfWeek}");
                }
                else
                {
                    Console.WriteLine("Error: bad input");
                }
            }
        }
    }
}
