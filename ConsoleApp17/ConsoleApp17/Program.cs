using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string p = "Компьютер - это то, без чего не обойтись ни одному человеку в наше время.";
            Console.WriteLine(p);
            Console.WriteLine("Введите символ, который будем искать:");
            char c1 = Convert.ToChar(Console.Read());
            c1 = Char.ToLower(c1);
            char c2 = char.ToUpper(c1);
            int poz = Math.Max(p.IndexOf(c1), p.IndexOf(c2));

            while (poz != -1)
            {
                int l = poz, r = poz;
                bool b1 = true, b2 = true;
                while (b1 || b2)
                {
                    if (b1 && l > 0 && char.IsLetter(p[l])) l--; else b1 = false;
                    if (b2 && r < p.Length - 1 && char.IsLetter(p[r])) r++; else b2 = false;
                }
                p = p.Remove(l, r - l);
                poz = Math.Max(p.IndexOf(c1), p.IndexOf(c2));
            }
            Console.WriteLine(p);
        }
    }
}