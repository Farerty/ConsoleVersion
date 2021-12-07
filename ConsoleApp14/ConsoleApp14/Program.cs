using System;

namespace ConsoleApp14
{
    class Program
    {
        class DoAny
        {
            static int counter = 0;
            static int counter1 = counter;
            static int[,] b;
            static int max = 0;
            public DoAny()
            {
                input();
                MassivFuller();
                Show1();
                MassivChanger();
                Console.WriteLine();
                Show1();
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
               
                b = new int[counter, counter];
                
                for (int i = 0; i < counter; i++)
                {
                    for (int j = 0; j < counter; j++)
                    {
                        b[i, j] = rand.Next(1, 100);
                        
                    }
                }
                
            }
            public static void MassivChanger()
            {
                int[] firstColon = new int[counter];
                int[] secondColon = new int[counter];
                for (int i = 0, c = counter - 1; i < counter; i++, c--)
                {
                    
                    if (i == counter / 2)
                    {
                        break;
                    }

                    for (int j = 0; j < counter; j++)
                    {
                        firstColon[j] = b[j, i];
                       
                    }
                    for (int j = 0; j < counter; j++)
                    {
                        secondColon[j] = b[j, c];
                        
                    }

                    for (int  j = 0; j < counter; j++)
                    {
                        b[j, i] = secondColon[j];

                        b[j, c] = firstColon[j];
                        
                    }
                    
                }
            }
            public static void Show1()
            {
                for(int i = 0; i< counter; i++)
                {
                    for(int j = 0; j < counter; j++)
                    {
                        Console.Write(b[i, j]+ " ");
                        if(j == counter - 1)
                        {
                            Console.WriteLine();
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
