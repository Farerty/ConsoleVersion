using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0;
            bool doAny = true;
            do
            {
                try
                {
                     Console.WriteLine("Enter x");
                     x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter y");
                     y = Convert.ToDouble(Console.ReadLine());
                    doAny = false;
                }
                catch
                {
                    Console.WriteLine("Invalid number");
                }
                
            } while (doAny == true);
            if (Math.Abs(x * x) + Math.Abs(y * y) > 15 * 15 && Math.Abs(x * x) + Math.Abs(y * y) < 25 * 25)
            {
                Console.WriteLine("Вне");
            }
            else if (Math.Abs(x * x) + Math.Abs(y * y) < 15 * 15)
            {
                Console.WriteLine("Внутри");
            }

            else if (Math.Abs(x * x) + Math.Abs(y * y) > 25 * 25)
            {
                Console.WriteLine("Внутри");
            }
            else
            {
                Console.WriteLine("на границе");
            }
        }

    }
}
