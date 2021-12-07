using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            const int i = 10; 
            factorial(i);
        }
        public static void factorial(int i)
        {
            if(i == 0)
            {
                Console.WriteLine("И больше лунатиков не стало на луне", i);
                return;
            }
            if(i == 1)
            {
                Console.WriteLine("Последний лунатик жил на луне");
                Console.WriteLine("Последний лунатик ворочился во сне", i);
                Console.WriteLine("Последний из лунатиков упал с луны во сне");
            }
            else
            {
                Console.WriteLine("{0} лунатиков жили на луне", i);
                Console.WriteLine("{0} лунатиков ворочились во сне", i);
                Console.WriteLine("Один из лунатиков упал с луны во сне");
                
            }
            factorial(i - 1);
        }
    }
    
}
