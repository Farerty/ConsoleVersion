using System;

namespace ConsoleApp9
{
    class DoAny
    {
        static int m, n, d;
        public DoAny()
        {
            input();

            d = factorial(m, n);

            Show1();

        }
        public static int factorial(int m, int n)
        {
            if(n == m)
            {
                return 1;
            }
            else if( m == 0)
            {
                return 1;
            }
            else if(n > m && m > 0)
            {
                return factorial(m,n-1) + factorial(m - 1, n - 1);

            }
            else
            {
                return 0;
            }          
        }
        public static void input()
        {
            bool flag = true;
            do
            {
                try
                {
                    Console.WriteLine("Write a number");
                    m = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Write a number");
                    n = Convert.ToInt32(Console.ReadLine());
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("invalid number");
                }
            } while (flag == true);
        } 
        public static void Show1()
        {
            Console.WriteLine("Result = {0}",d);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DoAny doo = new DoAny();

        }
    }
}
