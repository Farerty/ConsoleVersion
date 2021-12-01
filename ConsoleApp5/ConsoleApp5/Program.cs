using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            f1();
            f2();
            f3();
        }
        public static void f1()
        {
            bool doAnyDop = true;
            int counter = 0, counter1 = 0;

            int bublOfDouble = 1;
            double kursOfRubl = 0;
            Console.WriteLine("do_while");
            do
            {

                counter += 5;
                counter1++;

                try
                {
                    if(bublOfDouble == 1)
                    {
                        Console.WriteLine("Введите курс рубля");
                        kursOfRubl = Convert.ToDouble(Console.ReadLine());
                        bublOfDouble = 0;
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Invalid Number");
                }
                    
                if(counter1 % 8 == 0 )    {
                        Console.WriteLine("\n");
                    }
                else
                {
                    Console.Write(Math.Round(counter * kursOfRubl)+ " ");

                }
                if (counter == 120)
                {
                    doAnyDop = false;
                }
            } while (doAnyDop == true);
        }
        public static void f2()
        {
            bool doAnyDop = true;
            int counter = 0, counter1 = 0;

           int bublOfDouble = 1;
            double kursOfRubl = 0;
            Console.WriteLine("while");
            while (doAnyDop == true)
            {
                counter += 5;
                counter1++;

                try
                {
                    if (bublOfDouble == 1)
                    {
                        Console.WriteLine("Введите курс рубля");
                        kursOfRubl = Convert.ToDouble(Console.ReadLine());
                        bublOfDouble = 0;
                    }

                }
                catch
                {
                    Console.WriteLine("Invalid Number");
                }

                if (counter1 % 8 == 0)
                {
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.Write(Math.Round(counter * kursOfRubl) + " ");

                }
                if (counter == 120)
                {
                    doAnyDop = false;
                }
            }
        }
        public static void f3()
        {
            bool doAnyDop = true;
            int counter = 0, counter1 = 0;

            int bublOfDouble = 1;
            double kursOfRubl = 0;
            Console.WriteLine("for");
            for (; doAnyDop == true;)
            {
                counter += 5;
                counter1++;

                try
                {
                    if (bublOfDouble == 1)
                    {
                        Console.WriteLine("Введите курс рубля");
                        kursOfRubl = Convert.ToDouble(Console.ReadLine());
                        bublOfDouble = 0;
                    }

                }
                catch
                {
                    Console.WriteLine("Invalid Number");
                }

                if (counter1 % 8 == 0)
                {
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.Write(Math.Round(counter * kursOfRubl) + " ");

                }
                if (counter == 120)
                {
                    doAnyDop = false;
                }
            }
        }

    }
}
