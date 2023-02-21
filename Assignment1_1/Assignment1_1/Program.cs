using System;

namespace Assignment1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operand");
            string operand = Console.ReadLine();
            switch(operand)
            {
                case "+":
                    int result = num1 + num2;
                    Console.WriteLine("Addition :" +result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine("Substraction :" + result);
                    break;
                case "*":
                     result = num1 * num2;
                    Console.WriteLine("Multiplication :" + result);
                    break;
                case "/":
                     result = num1 / num2;
                    Console.WriteLine("Division :" + result);
                    break;
                default:
                    Console.WriteLine("Invalid Operations");
                    break;
            }
            Console.ReadLine();
        }
    }
}
