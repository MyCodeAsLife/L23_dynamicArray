﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L23_dynamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandExit = "exit";
            const string CommandSum = "sum";

            int[] numbers = new int[0];
            string userInput;
            bool isOpen = true;

            while (isOpen)
            {
                Console.Clear();
                Console.WriteLine($"Для выхода введите команду - {CommandExit}");
                Console.WriteLine($"Для суммирования всех введеных начиней, введите команду - {CommandSum}");
                Console.Write("Введите значение для добавления в массив: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandExit:
                        isOpen = false;
                        continue;

                    case CommandSum:
                        Console.Clear();
                        Console.WriteLine("Массив введеных пользователем значений:");
                        int sum = 0;

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            sum += numbers[i];
                            Console.Write(numbers[i] + " ");
                        }

                        Console.WriteLine($"\n\nСумма всех введеных чисел: {sum}");
                        Console.ReadKey();
                        break;

                    default:
                        int[] tempArray = new int[numbers.Length + 1];

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            tempArray[i] = numbers[i];
                        }

                        numbers = tempArray;
                        numbers[numbers.Length - 1] = Convert.ToInt32(userInput);
                        break;
                }
            }
        }
    }
}
