using System;

namespace ConsoleApp11
{
    class Program
    {
        class DoAny
        {
            public static double num1, num2, h;
            public DoAny()
            {
                input();
                DiaOfGr();
                
            }
            private static void input()
            {
                bool doDopAny = true;
                do
                {
                    try
                    {
                        Console.WriteLine("Введите начало диапазона:");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        if(num1 < 0)
                        {
                            throw new Exception();
                        }
                        Console.WriteLine("Введите конец диапазона:");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        if(num2 < num1 || num2 == 0)
                        {
                            throw new Exception();
                        }
                        Console.WriteLine("Введите шаг:");
                        h = Convert.ToDouble(Console.ReadLine());
                        if (h <= 0)
                        {
                            throw new Exception();
                        }
                        doDopAny = false;
                    }
                    catch
                    {
                        Console.WriteLine("Либо вы ввели что-то не то, либо ввели не правильное начало диапазона!\n Или вы настолько приисполнились, что начало диапазона больше его конца?");
                        Console.WriteLine("Либо вы ввели в качестве конца 0, что не имеет смысла.");
                    }
                    
                } while (doDopAny == true);
            }

            private static double DoImpotantThing(double i)
            {

                try
                {
                    if (i == 1)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        return Math.Log10(i - 1);
                    }
                }
                catch
                {
                    throw;
                }
            }
            private static void DiaOfGr()
            {
                for(double i = num1; i < num2; i += h)
                {
                    try
                    {
                        Console.WriteLine("y({0}) = {1}", i, DoImpotantThing(i));
                    }
                    catch
                    {
                        Console.WriteLine("y({0}) = error", i);
                    }
                    
                }
            }
        }


        static void Main(string[] args)
        {
            DoAny a = new DoAny();
        }
    }
}
