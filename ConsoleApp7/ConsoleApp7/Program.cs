using System;

namespace ConsoleApp7
{
    class Program
    {
        class DoAny
        {
            public static int numberFirst, numberSecond, numberOfresultSum;

            public DoAny()
            {
                input();
                ishak();
            }
           
            public static int LitleNumber(int n)
            {
                int numberWithoutEnd = 1;
                numberWithoutEnd = n;
                n /= 10;
                n *= 10;
                numberWithoutEnd = numberWithoutEnd - n;
                return numberWithoutEnd;
            }
            public static void input()
            {
                bool doAny = true;
                do
                {
                    try
                    {
                        Console.WriteLine("Write a number");
                        numberFirst = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Write a number");
                        numberSecond = Convert.ToInt32(Console.ReadLine());
                        doAny = false;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid number");
                    }
                } while (doAny == true);
            }
            public static void ishak()
            {
                numberFirst = LitleNumber(numberFirst);
                numberSecond = LitleNumber(numberSecond);
                numberOfresultSum = numberFirst + numberSecond;
                Console.WriteLine("Result is {0}", numberOfresultSum);
            }

        }
        static void Main(string[] args)
        {
            DoAny a = new DoAny();
        }
        
       
    }
    
}
