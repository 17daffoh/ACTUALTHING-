using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> options = new List<string> { "exit", "greet", "sum", "divide", "swap", "multiply three numbers", "number cruncher", "multiplication table", "average"};

            menu(options);
        }

        private static void menu(List<string> options)
        {
            int option = 1;
            while (option != 0)
            {
                for (int i = 0; i < options.Count; i++)
                {
                    Console.WriteLine($"{i}: {options[i]}");
                }
                Console.Write("Enter the number you would like to select: ");
                option = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Exiting... See you soon!");
                        break;
                    case 1:
                        greet();
                        break;
                    case 2:
                        sum();
                        break;
                    case 3:
                        divide();
                        break;
                    case 4:
                        swap();
                        break;
                    case 5:
                        multiplyThreeNumbers();
                        break;
                    case 6:
                        numberCrunch();
                        break;
                    case 7:
                        multiplicationTable();
                        break;
                    case 8:
                        average();
                        break;
                    default:
                        Console.WriteLine("Pleaase enter a valid number. ");
                        break;
                }
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
            }
        }

        private static void average()
        {
            Console.WriteLine("AVERAGE FINDER!");
            Console.WriteLine("Enter four numbers:  ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());
            double answer = number1 + number2 + number3 + number4;
            answer = answer / 4;
            Console.WriteLine($"The average of {number1} {number2} {number3} and {number4} is {answer}.");
        }

        private static void multiplicationTable()
        {
            Console.WriteLine("MULTIPLICATION TABLE MAKER!");
            Console.WriteLine("Enter a number:  ");
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i <= 10; i++)
            {
                int answer = number * i;
                Console.WriteLine($"{number} multiplied by {i} is equal to {answer}.");
                System.Threading.Thread.Sleep(500);
            }
            System.Threading.Thread.Sleep(1000);
        }

        private static void numberCrunch()
        {
            Console.WriteLine("THE NUMBER CRUNCHER!");
            Console.WriteLine("Enter two numbers:  ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int added = number1 + number2;
            int subtracted = number1 - number2;
            int multiplied = number1 * number2;
            int divided = number1 / number2;
            Console.WriteLine($"{number1} add {number2} is {added}.");
            Console.WriteLine($"{number1} minus {number2} is {subtracted}.");
            Console.WriteLine($"{number1} multiplied by {number2} is {multiplied}.");
            Console.WriteLine($"{number1} divided by {number2} is {divided}.");
        }

        private static void multiplyThreeNumbers()
        {
            Console.WriteLine("MULTIPLY THREE NUMBERS!");
            Console.WriteLine("Enter three numbers:  ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int result = number1 * number2 * number3;
            Console.WriteLine($"The result of {number1} * {number2} * {number3} is {result}.");
        }

        private static void swap()
        {
            Console.WriteLine("NUMBER SWAPPER");
            Console.WriteLine("Enter two numbers to be swapped:  ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine($"{number1} {number2}");
        }

        private static void divide()
        {
            Console.WriteLine("NUMBER DIVIDER!");
            Console.WriteLine("Enter two numbers:  ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int divided = number1 / number2;
            Console.WriteLine($"{number1} divided by {number2} is {divided}.");
        }

        private static void sum()
        {
            Console.WriteLine("NUMBER ADDER!");
            Console.WriteLine("Enter two numbers:  ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int sum = number1 + number2;
            Console.WriteLine($"The sum of {number1} and {number2} is {sum}.");
        }

        private static void greet()
        {
            Console.WriteLine("GREETER!");
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }
    }
}