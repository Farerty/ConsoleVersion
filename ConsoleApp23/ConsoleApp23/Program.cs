using System;

namespace ConsoleApp23
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
            }
            public  void MassivFuller()
            {
                try
                {
                    int i = 0;
                    do
                    {

                        Console.WriteLine("Введите число:");
                        int numberOfUser = Convert.ToInt32(Console.ReadLine());
                        IntArray[i] = numberOfUser;
                        i++;

                    } while (i < n);


                }
                catch
                {
                    Console.WriteLine("invalid number");
                }


            }
            public  void MassivFuller(int size)
            {
                Random rnd = new Random();
                for (int i = 0; i < size; i++)
                {
                    IntArray[i] = rnd.Next(-10, 10);
                }
            }
            public  void sort()
            {
                Array.Sort(IntArray);
            }

            public int SizeOfMassiv
            {
                get { return n; }

            }
            public int ScalUmOnMassiv
            {
                set
                {
                    int scal = value;
                    for (int i = 0; i < n; i++)
                    {
                        IntArray[i] = IntArray[i] * scal;
                    }
                }
            }
            public  void MassivShowev()
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(IntArray[i] + " ");
                }
            }
            public  int this [int i]
            {
                get
                {
                    return IntArray[i];
                }
                set
                {
                    IntArray[i] = value;
                }
            }
            public static DoAny operator ++ (DoAny a)
            {
                DoAny temp = a;
                for(int i = 0; i < n; i++)
                {
                    temp[i] = temp[i] + 1;
                }
                return temp;
            }
            public static DoAny operator --(DoAny a)
            {
                DoAny temp = a;
                for (int i = 0; i < n; i++)
                {
                    temp[i] = temp[i] - 1;
                }
                return temp;
            }
            public static DoAny operator * (DoAny a,int scal)
            {
                DoAny temp = a;
                for (int i = 0; i < temp.SizeOfMassiv; i++)
                {
                    temp[i] = temp[i] * scal;
                }
                return temp;
            }
            public static bool operator ! (DoAny a)
            {
                int counter = 1;
                for(int i = 1; i < n; i++)
                {
                    if(IntArray[i-1] < IntArray[i])
                    {
                        counter++;
                    }
                }
                if(counter == n)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            public static implicit operator int[](DoAny a)
            {
                int[] temp = new int[n];
                for(int i =0; i< n; i++)
                {
                    temp[i] = IntArray[i];
                }
                return temp;
            }
            public static implicit operator DoAny(int[] a)
            {
                DoAny temp = new DoAny(n);
                for (int i = 0; i < n; i++)
                {
                    temp[i] = a[i];
                }
                return temp;
            }
            

        }
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Введите размер масcива");
                int n = Convert.ToInt32(Console.ReadLine());
                DoAny a = new DoAny(n);
                a.MassivFuller();
                Console.WriteLine("Введённый массив:");
                a.MassivShowev();
                Console.WriteLine();
                a.sort();
                Console.WriteLine("Отсортированный массив:");
                a.MassivShowev();
                Console.WriteLine();
                Console.WriteLine("Первый элемент массива: " + a[0]);
                Console.WriteLine();
                Console.WriteLine("Размер массива:");
                Console.WriteLine(a.SizeOfMassiv);
                int[] u = new int[n];
                int[] y = new int[n];
                Console.WriteLine();
                u = a;
                Console.WriteLine("Записанный массив в инт");
                for(int i = 0; i< n; i++)
                {
                    Console.Write(u[i] + " ");
                }
                Console.WriteLine();
                bool flag = true;
                Console.WriteLine("Записанный в объект класса массив:");
                a = u;
                a.MassivShowev();
                Console.WriteLine();
                do
                {
                    try
                    {
                        int scal = 0;
                        Console.WriteLine("Введите скаляр:");
                        a.ScalUmOnMassiv =  scal = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Домноженный на скаляр массив:");
                        a.MassivShowev();
                        Console.WriteLine();
                        flag = false;
                        y = a * scal;
                        Console.WriteLine("Домноженный другим способом на скаляр массив: ");
                        a.MassivShowev();
                        Console.WriteLine();
                        a = a++;
                        Console.WriteLine("Увеличенный на единицу массив:");
                        a.MassivShowev();
                        Console.WriteLine();
                        Console.WriteLine("Уменьшенный на единицу массив:");
                        a = a--;
                        a.MassivShowev();
                        Console.WriteLine();
                        Console.WriteLine("Отсортирован по возрастанию?");
                        Console.WriteLine(!a);
                    }
                    catch
                    {
                        Console.WriteLine("invalid number");
                    }
                } while (flag == true);

            }
            catch
            {
                Console.WriteLine("invalid number");
            }
           
        }
    }
}
