using System;

namespace ConsoleApp12
{
    class Program
    {
        class DoAny
        {
            static int counter;
            static int[] a;
            static int[,] b;
            static int max = 0;
            static int maxDop = 0;
            public DoAny()
            {
                input();
                MassivFuller();
            }
            public static void input()
            {
                bool Flag = true;
                do
                    {
                try
                {
                    
                        Console.WriteLine("Введите размер массива:");
                        counter = Convert.ToInt32(Console.ReadLine());
                        Flag = false;
                    
                }
                catch
                {
                    Console.WriteLine("invalid number");
                }
                } while (Flag == true);

            }
            public static void MassivFuller()
            {
                
                Random rand = new Random();
                a = new int[counter];
                b = new int[counter, counter];
                for(int i = 0; i < counter; i++)
                {
                    a[i] = rand.Next(1, 100);
                    max += a[i];
                }
                for(int i = 0; i< counter; i++)
                {
                    for(int j = 0; j< counter; j++)
                    {
                        b[i, j] = rand.Next(1, 100);
                        maxDop += b[i, j];
                    }
                }
                Console.WriteLine("Среднее арифмитеское одномерного массива {0}", max / counter);
                Console.WriteLine("Среднее арифмитеское двумерного массива {0}", maxDop / counter);
            }
            
        }

        static void Main(string[] args)
        {
            DoAny p = new DoAny();
        }
    }
}
