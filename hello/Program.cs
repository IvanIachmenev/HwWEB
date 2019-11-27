using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World"); //1.1 задание


            Console.WriteLine("Введите число: а"); //1.2 задание
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число: b");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите одну из операций: +, -, /, *");
            var operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine(a+b);
                break;
                case "-":
                    Console.WriteLine(a-b);
                break;
                case "/":
                    if(b == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя!!!!!");
                        break;
                    }
                    Console.WriteLine(a/b);
                break;
                case "*":
                    Console.WriteLine(a*b);
                break;
                default:
                    Console.WriteLine("Невозможно совершить операцию");
                break;
            }
        }
    }
}