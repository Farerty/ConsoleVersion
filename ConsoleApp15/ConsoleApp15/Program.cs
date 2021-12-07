using System;

namespace ConsoleApp15
{
    class Program
    {
        class DoAny
        {
            static int counter = 0;
            static int counter1 = counter;
            static int[] a;
            static int[][] b;
            static int max = 0;
            bool flag = true;
            public DoAny()
            {
                input();
                MassivFuller();
                Show1();
               
                Console.WriteLine();
                Show1(flag);
            }

            private static void input()
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
            private static void MassivFuller()
            {

                Random rand = new Random();

                b = new int[counter][];
                a = new int[counter];
                for (int i = 0; i < counter; i++)
                {
                    b[i] = new int[counter];
                    for (int j = 0; j < counter; j++)
                    {
                        b[i][j] = rand.Next(-10, 30);
                        if (b[i][j] > 0)
                        {
                            a[i] += 1;
                        }

                    }
                }


            }
            
            private static void Show1()
            {
                for (int i = 0; i < counter; i++)
                {
                    for (int j = 0; j < counter; j++)
                    {
                        Console.Write(b[i][j] + " ");
                        if (j == counter - 1)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
            private static void Show1(bool flag)
            {
                for(int i = 0; i< counter; i++)
                {
                    Console.WriteLine("Для строки {0} количество положительных элементов {1}", i+1, a[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            DoAny d = new DoAny();
        }
    }
}
