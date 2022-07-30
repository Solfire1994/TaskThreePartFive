using System;

namespace TaskThreePartFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давай сыграем в игру Угадай число, введи верхнюю границу для игры");
            int upperBound = int.Parse(Console.ReadLine());
            Random random = new Random();
            Console.Clear();
            Console.WriteLine("Игра началась, попробуй угадать");
            int number = random.Next(0, upperBound + 1);
            int userNumber;
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "")
                {
                    Console.WriteLine("Вы рано сдались, загаданное число {0}", number);
                    break;
                }
                else
                {
                    userNumber = int.Parse(str);
                    if (userNumber < number)
                    {
                        Console.WriteLine("Загаданное число больше");
                    }
                    else if (userNumber > number)
                    {
                        Console.WriteLine("Загаданное число меньше");
                    }
                    else
                    {
                        Console.WriteLine("Вы угадали, загаданное число {0}", number);
                        break;
                    }
                }
            }

        }
    }
}
