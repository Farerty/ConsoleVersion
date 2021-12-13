using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp18
{
    class Program
    {

        static void Main(string[] args)
        {
            string str = "Компьютер – это электронно-вычислительная машина, способная выполнять заданную последовательность операций, называемую программой. Само слово «компьютер» произошло от английских to compute («вычислять») и computer («вычислитель»).";
            Console.WriteLine(str);
           
            var newtext = Regex.Replace(str, "[-.?!)(,:]", " ");
            Console.WriteLine(newtext);
        }
    }
}
