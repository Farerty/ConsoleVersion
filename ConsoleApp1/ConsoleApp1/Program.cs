using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double theA = 0, theB = 0;
            bool goToNextNum = true;
            do
            {
                try
                {
                    Console.WriteLine("Write the katet a: ");
                    theA = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Write the katet b: ");
                    theB = Convert.ToDouble(Console.ReadLine());
                    goToNextNum = false;
                }
                catch
                {
                    Console.WriteLine("Invalid Number");
                }
            } while (goToNextNum == true);
            double theC = 0;
            theC = Math.Sqrt(theA * theA + theB * theB);
            Console.WriteLine("Гипотенуза равна = {0}", theC);
        }
    }
}
