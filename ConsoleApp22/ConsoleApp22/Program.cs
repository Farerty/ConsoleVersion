using System;

namespace ConsoleApp22
{
    class Program
    {
        class DoAny
        {
            static int[] IntArray;
            static int n;
            public DoAny(int size)
            {
                n = size;
                IntArray = new int[size];
                MassivFuller();
                MassivShowev();
                Console.Write
                SortOfMassiv();
                MassivShowev();
                Console.WriteLine(SizeOfMassiv);
                ScalUmOnMassiv = 3;
                MassivShowev();
            }
            public static void MassivFuller()
            {

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Введите число:");
                    int numberOfUser = Convert.ToInt32(Console.ReadLine());
                    IntArray[i] = numberOfUser;
                }
                
            }
            public static void MassivFuller(int size)
            {
                Random rnd = new Random();
                for(int i = 0; i < size; i++)
                {
                    IntArray[i] = rnd.Next(-10, 10);
                }
            } 
            public static void sort()
            {
                Array.Sort(IntArray);
            }
            public static void Swap<T>(ref T a, ref T b)
            {
                T tmp = a;

                a = b;
                b = tmp;
            }
            public static void SortOfMassiv()
            {
                for (var i = 1; i < n; i++)
                {
                    var key = IntArray[i];
                    var j = i;
                    while ((j > 1) && (IntArray[j - 1] > key))
                    {
                        Swap(ref IntArray[j - 1], ref IntArray[j]);
                        j--;
                    }

                    IntArray[j] = key;
                }
            }
            int SizeOfMassiv
            {
                get { return n; }
                
            }
            int ScalUmOnMassiv
            {
                set
                {
                    int scal = value;
                    for(int i = 0; i < n; i++)
                    {
                        IntArray[i] = IntArray[i] * scal;
                    }
                }
            }
            public static void MassivShowev()
            {
                for(int i = 0; i < n; i++)
                {
                    Console.Write(IntArray[i] + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер масcива");
            int n = Convert.ToInt32(Console.ReadLine());
            DoAny a = new DoAny(n);
        }
    }
}
