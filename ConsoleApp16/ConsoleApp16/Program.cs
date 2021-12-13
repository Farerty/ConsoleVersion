using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp16
{
    class Program
    {
        
            public static void Main()
            {

                bool f = false;
                Console.WriteLine("Введите строку: ");
                StringBuilder str = new StringBuilder(Console.ReadLine());
                Console.WriteLine("Исходная строка {0} ", str);

                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (str[i] == str[i + 1])
                        f = true;
                }
                if (f == true)
                    Console.WriteLine("Есть одинаковые символы");
                else
                    Console.WriteLine("Нету одинаковых символов");
        }


	}
}
