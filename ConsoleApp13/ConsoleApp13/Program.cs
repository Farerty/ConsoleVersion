using System;

namespace ConsoleApp13
{
    class Program
    {
        class DoAny
        {
            static int counter;
            static double[] a;
            static double[,] b;
            static double max = 0;
            
            public DoAny()
            {
                input();
                MassivFuller();
                doAny();
            }
            public static void input()
            {
                bool doAnyDop = true;
                do
                {
                    try
                    {
                        Console.WriteLine("Введите размер массива:");
                        counter = Convert.ToInt32(Console.ReadLine());
                        doAnyDop = false;
                    }
                    catch
                    {
                        Console.WriteLine("invalid number");
                    }
                } while (doAnyDop == true);
            }
            public static void MassivFuller()
            {

                Random rand = new Random();
                a = new double[counter];
                b = new double[counter, counter];
                
                for (int i = 0; i < counter; i++)
                {
                    a[i] = rand.Next(1, 100);

                }
                for (int i = 0; i < counter; i++)
                {
                    for (int j = 0; j < counter; j++)
                    {
                        b[i, j] = rand.Next(1, 100);
                       
                    }
                }
                
            }
            public static void MAx()
            {
                max = a[0];
                for(int i = 0; i< counter; i++)
                {
                    if(max < a[i])
                    {
                        max = a[i];
                    }
                }
                
            }
            public static void MAx(bool flag)
            {
                max = b[0,0];
                for (int i = 0; i < counter; i++)
                {
                    for(int j = 0; j < counter; j++)
                    {
                        if(max< b[i, j])
                        {
                            max = b[i, j];
                        }
                    }
                }
            }
            public static void doAny()
            {
                MAx();
                Console.WriteLine("Индексы элементов одномерного массива:");
                for(int i = 0; i< counter; i++)
                {
                    if(a[i] != max)
                    {
                        Console.Write("{0} ", i);
                    }
                }
                Console.WriteLine();
                bool flag = true;
                MAx(flag);
                Console.WriteLine("Индексы элементов двумерного массива:");
                for (int i = 0; i < counter; i++)
                {
                    for(int j = 0;j< counter; j++)
                    {
                        if (b[i, j] < max)
                        {
                            Console.Write("{0} {1} ", i, j + " ");
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            DoAny d = new DoAny();
        }
    }
}
