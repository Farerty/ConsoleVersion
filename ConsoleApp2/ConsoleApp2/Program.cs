using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double theA = 0, theB = 0, TheC = 0;
            bool theResult = false;
            bool goToNextNum = true;
            do
            {
                try
                {
                    Console.WriteLine("Write the a: ");
                    theA = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Write the b: ");
                    theB = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Write the b: ");
                    TheC = Convert.ToDouble(Console.ReadLine());
                    goToNextNum = false;
                }
                catch
                {
                    Console.WriteLine("Invalid Number");
                }
            } while (goToNextNum == true);
            theResult = resultOfUr(theA, theB, TheC);
            if (theResult)
            {
                Console.WriteLine(theResult);
            }
            else
            {
                Console.WriteLine(theResult);
            }
        }
        public static bool resultOfUr(double a, double b, double c)
        {
            double result = b * b - 4 * a * c;
            if (result <= 0)
            {
                return false;
            }
            else if (result > 0)
            {
                return true;
            }
            return false;
        }

    }

}
