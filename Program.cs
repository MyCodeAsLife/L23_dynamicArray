using System;
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

            int[] mainArray = new int[1];
            int sumElements;
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
                        sumElements = 0;

                        for (int i = 0; i < mainArray.Length - 1; i++)
                        {
                            sumElements += mainArray[i];
                            Console.Write(mainArray[i] + " ");
                        }
                        Console.WriteLine($"\n\nСумма всех введеных чисел: {sumElements}");
                        Console.ReadKey();
                        break;

                    default:
                        mainArray[mainArray.Length - 1] = Convert.ToInt32(userInput);
                        int[] tempArray = new int[mainArray.Length + 1];

                        for (int i = 0; i < mainArray.Length; i++)
                        {
                            tempArray[i] = mainArray[i];
                        }
                        mainArray = tempArray;
                        break;
                }
            }
        }
    }
}
