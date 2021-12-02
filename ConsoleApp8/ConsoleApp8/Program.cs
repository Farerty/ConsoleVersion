using System;

namespace ConsoleApp8
{
    class Program
    {
        class DoAny
        {
            static double numberOfBegin, numberOfEnd;
            static double h;
            static double[] a;
            
            static int counter;

            public DoAny()
            {
                input();
                doAny();
                
            }
            public static void input()
            {
                bool doAny = true;
                do
                {
                    try
                    {
                        Console.WriteLine("Write a number");
                        numberOfBegin = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Write a number");
                        numberOfEnd = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Write a step");
                        h = Convert.ToDouble(Console.ReadLine());
                        if(numberOfBegin % h == 0 && numberOfEnd % h == 0)
                        {
                            doAny = false;
                        }                       
                    }
                    catch
                    {
                        Console.WriteLine("Invalid number");
                    }
                } while (doAny == true);
            }
            public static void doAny()
            {
                for(double i = numberOfBegin; i < numberOfEnd; i += h)
                {
                    counter++;
                }
                a = new double[counter];
                int counter1 = 0;
                Console.WriteLine("With out");
                for (double i = numberOfBegin; i < numberOfEnd; i += h)
                {
                    SearchOfF(i,out a[counter1]); 
                    counter1++;
                }
                Show();
                counter1 = 0;
                Console.WriteLine("\n");
                Console.WriteLine("Without out");
                for (double i = numberOfBegin; i < numberOfEnd; i += h)
                {
                    a[counter1] = SearchOfF(i);
                    counter1++;
                }
                Show();

            }
            private static void Show()
            {
                
                    for (int i = 0; i < counter; i++)
                    {
                        Console.Write(a[i] + " ");
                        
                    }    
            }
            public static double SearchOfF(double x)
            
            {
                if ((x * x - 5 * x) < 0)
                {
                   return numberOfBegin + numberOfEnd;
                }
                else if (0 <= (x * x - 5 * x) && (x * x - 5 * x) < 10)
                {
                    return numberOfBegin - numberOfEnd;
                }
                else if ((x * x - 5 * x) >= 10)
                {
                   return numberOfBegin * numberOfEnd;
                }
                else
                {
                   return 0;
                }
            }
            public static void SearchOfF(double x, out double y)
            {
                if((x*x - 5 * x) < 0)
                {
                    y = numberOfBegin + numberOfEnd;
                }
                else if(0<= (x * x - 5 * x) && (x * x - 5 * x) < 10)
                {
                    y = numberOfBegin - numberOfEnd;
                }
                else if((x * x - 5 * x) >= 10)
                {
                    y = numberOfBegin * numberOfEnd;
                }
                else
                {
                    y = 0;
                }
            }
            
        }
        static void Main(string[] args)
        {
            DoAny t = new DoAny();
        }
    }
}
