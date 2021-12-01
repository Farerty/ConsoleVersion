using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            bool goToNextNum = true;
            int n = 0;
            int k = 0;
            do
            {
                try
                {
                    Console.WriteLine("Write the a: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Write the b: ");
                    k = Convert.ToInt32(Console.ReadLine());
                    if (1 <= n && n <= 4 && 6 <= k && k <= 14)
                    {
                        goToNextNum = false;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid Number");
                }
            } while (goToNextNum == true);
            if (n == 0)
            {
                n += 1;
            }

            switch (n)
            {
                case 1: Console.WriteLine("Пики"); mast1(k); break;
                case 2: Console.WriteLine("Черви"); mast2(k); break;
                case 3: Console.WriteLine("Крести"); mast3(k); break;
                case 4: Console.WriteLine("Бубны"); mast4(k); break;


            }

        }
        public static void mast1(int k)
        {
            switch (k)
            {

                case 6: Console.WriteLine("Шестёрка пик"); break;
                case 7: Console.WriteLine("Семёрка пик"); break;
                case 8: Console.WriteLine("Восьмёрка пик"); break;
                case 9: Console.WriteLine("Девятка пик"); break;
                case 10: Console.WriteLine("Десятка пик"); break;
                case 11: Console.WriteLine("Валет вини"); break;
                case 12: Console.WriteLine("Дама пик"); break;
                case 13: Console.WriteLine("Король пик"); break;
                case 14: Console.WriteLine("Туз пик"); break;
            }
        }

        public static void mast2(int k)
        {
            switch (k)
            {

                case 6: Console.WriteLine("Шестёрка черви"); break;
                case 7: Console.WriteLine("Семёрка черви"); break;
                case 8: Console.WriteLine("Восьмёрка черви"); break;
                case 9: Console.WriteLine("Девятка черви"); break;
                case 10: Console.WriteLine("Десятка черви"); break;
                case 11: Console.WriteLine("Валет черви"); break;
                case 12: Console.WriteLine("Дама черви"); break;
                case 13: Console.WriteLine("Король черви"); break;
                case 14: Console.WriteLine("Туз черви"); break;
            }
        }

        public static void mast3(int k)
        {
            switch (k)
            {

                case 6: Console.WriteLine("Шестёрка треф"); break;
                case 7: Console.WriteLine("Семёрка треф"); break;
                case 8: Console.WriteLine("Восьмёрка треф"); break;
                case 9: Console.WriteLine("Девятка треф"); break;
                case 10: Console.WriteLine("Десятка треф"); break;
                case 11: Console.WriteLine("Валет треф"); break;
                case 12: Console.WriteLine("Дама треф"); break;
                case 13: Console.WriteLine("Король треф"); break;
                case 14: Console.WriteLine("Туз крести"); break;
            }
        }
        public static void mast4(int k)
        {
            switch (k)
            {

                case 6: Console.WriteLine("Шестёрка бубен"); break;
                case 7: Console.WriteLine("Семёрка бубен"); break;
                case 8: Console.WriteLine("Восьмёрка бубенк"); break;
                case 9: Console.WriteLine("Девятка бубен"); break;
                case 10: Console.WriteLine("Десятка бубен"); break;
                case 11: Console.WriteLine("Валет бубен"); break;
                case 12: Console.WriteLine("Дама бубен"); break;
                case 13: Console.WriteLine("Король бубен"); break;
                case 14: Console.WriteLine("Туз бубен"); break;
            }
        }


    }


}
