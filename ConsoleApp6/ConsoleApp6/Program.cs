using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колическтво строк");
            bool doAnyDop = true, doAny = true;
            int numberOfStrok = 0;
            do
            {

                try
                {
                    numberOfStrok = Convert.ToInt32(Console.ReadLine());
                    doAny = true;
                }
                catch
                {
                    Console.WriteLine("Invalid Number");
                    doAny = false;
                }
                if (doAny)
                {
                    doAnyDop = false;
                }

            } while (doAnyDop == true);
            rekFun(numberOfStrok);
        }
        public static int rekFun(int n)
        {
            if (n == 1 || n == 0)
            {
                Console.Write(1);
                return 1;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(1 + " ");
                if (i == n - 1)
                {
                    Console.Write("\n");
                }
            }
            return rekFun(n - 1);
        }

    }
}
