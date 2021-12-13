using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp19
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Записанный массив:");
            using (BinaryWriter BW = new BinaryWriter(File.Open(@"mas.bin", FileMode.Create)))
            {
                bool Flag = true;
                int count = 0;
                do
                {
                    try
                    {
                        Console.WriteLine("Введите размер массива:");
                        count = Convert.ToInt32(Console.ReadLine());
                        Flag = false;
                    }
                    catch
                    {
                        Console.WriteLine("invalid number");
                    }
                } while (Flag == true);

                if(Flag == false)
                {
                    for (int i = 0; i < count; i++)
                    {
                        int number = rnd.Next(-10, 11);
                        if(number < 0)
                        {
                            BW.Write(number);                            
                        }
                        Console.Write(number + " ");
                    }
                    BW.Close();
                    Console.WriteLine("\nПрочитанный массив:");
                    using (BinaryReader BR = new BinaryReader(File.Open(@"mas.bin", FileMode.Open)))
                    {
                        List<int> list = new List<int>();
                        while (BR.BaseStream.Position != BR.BaseStream.Length)
                        {
                            list.Add(BR.ReadInt32());
                        }
                        Console.WriteLine(string.Join(" ", list));
                        BR.Close();
                    }
                    
                }

            }
        }
    }
}
