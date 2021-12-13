using System;
using System.IO;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            int minLenghtLineIndex = 0;
            int minLenght = Int32.MaxValue;
            int counter = 1;

            foreach (string line in File.ReadLines(@"ter.txt"))
            {
                if (line.Length < minLenght)
                {
                    minLenght = line.Length;
                    minLenghtLineIndex = counter;
                }
                counter++;
            }

            Console.WriteLine("Номер самой короткой строки {0}",minLenghtLineIndex);
            Console.ReadLine();
        }
    }
}
