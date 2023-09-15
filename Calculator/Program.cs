using System;
class Program
{
    static void Main()
    {
        bool continueCalculations = true;

        Console.WriteLine("C# Calculator by James Sweetsir");
        Thread.Sleep(2000);

        while (continueCalculations)
        {
            Console.WriteLine("Calculator Menu:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice (1-5): ");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "1":
                    Console.Write("Please enter the first number: ");
                    double number1 = double.Parse(Console.ReadLine());
                    Console.Write("Please enter the second number: ");
                    double number2 = double.Parse(Console.ReadLine());
                    double result = number1 + number2;
                    Console.WriteLine($"Result: {result}");
                    break;

                case "2":
                    Console.Write("Please enter the first number: ");
                    number1 = double.Parse(Console.ReadLine());
                    Console.Write("Please enter the second number: ");
                    number2 = double.Parse(Console.ReadLine());
                    result = number1 - number2;
                    Console.WriteLine($"Result: {result}");
                    break;

                case "3":
                    Console.Write("Please enter the first number: ");
                    number1 = double.Parse(Console.ReadLine());
                    Console.Write("Please enter the second number: ");
                    number2 = double.Parse(Console.ReadLine());
                    result = number1 * number2;
                    Console.WriteLine($"Result: {result}");
                    break;

                case "4":
                    Console.Write("Please enter the first number: ");
                    number1 = double.Parse(Console.ReadLine());
                    Console.Write("Please enter the second number: ");
                    number2 = double.Parse(Console.ReadLine());

                    if (number2 == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    else
                    {
                        result = number1 / number2;
                        Console.WriteLine($"Result: {result}");
                    }
                    break;

                case "5":
                    continueCalculations = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}