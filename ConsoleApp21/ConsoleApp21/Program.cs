using System;
using System.IO;
using System.Text;

namespace ConsoleApp21
{
    
        class DoAny
        {
            public DoAny()
            {
                DoAnyMore();
            }
            string strTxt1 = "Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов", strTxt2 = "Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс";
            StringBuilder strTxt3 = new StringBuilder();
            string path1 = @"C:\temp\K1\";
            string path2 = @"C:\temp\K2\";
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\temp");
            void DoAnyMore()
            {
                try
                {
                    strTxt3.Append(strTxt1);
                    strTxt3.Append("\n");
                    strTxt3.Append(strTxt2);
                    if (!dirInfo.Exists)
                    {
                        dirInfo.Create();
                    }
                    else
                    {
                        dirInfo.Delete(true);
                        dirInfo.Create();
                    }
                    dirInfo.CreateSubdirectory("K1");
                    FileStream textInK1 = File.Create(path1 + @"\t1.txt");
                    textInK1.Close();
                    StreamWriter sw1 = new StreamWriter(path1 + @"\t1.txt");
                    sw1.WriteLine(strTxt1);
                    dirInfo.CreateSubdirectory("K2");
                    FileStream textInK2= File.Create(path1 + @"\t2.txt");
                    textInK2.Close();
                    FileStream txt3 = File.Create(path2 + @"\t3.txt");
                    txt3.Close();
                    StreamWriter swTXT2 = new StreamWriter(path1 + @"\t2.txt", false);
                    StreamWriter swTXT3 = new StreamWriter(path2 + @"\t3.txt", false);
                    swTXT2.WriteLine(strTxt2);
                    sw1.Close();
                    swTXT2.Close();
                    swTXT3.Write(strTxt3.ToString());
                    swTXT3.Close();
                    StreamReader srTXT1 = new StreamReader(path1 + @"\t1.txt");
                    Console.WriteLine(@"Первый файл с распололжением C:\temp\K1\t1.txt");
                    Console.WriteLine(srTXT1.ReadToEnd().ToString());
                    Console.WriteLine(@"Второй файл с распололжением C:\temp\K1\t2.txt");
                    StreamReader srTXT2 = new StreamReader(path1 + @"\t2.txt");
                    Console.WriteLine(srTXT2.ReadToEnd().ToString());
                    Console.WriteLine(@"Третий файл с распололжением C:\temp\K2\t3.txt");
                    StreamReader srTXT3 = new StreamReader(path2 + @"\t3.txt");
                    Console.WriteLine(srTXT3.ReadToEnd().ToString());
                    srTXT1.Close();
                    srTXT2.Close();
                    srTXT3.Close();
                    File.Move(path1 + @"\t1.txt", path2 + @"\t1.txt");
                    File.Move(path1 + @"\t2.txt", path2 + @"\t2.txt");
                    Directory.Move(path2, @"C:\temp\ALL");
                    Directory.Delete(@"C:\temp\K1", true);
                    string[] files = Directory.GetFiles(@"C:\temp\ALL");
                    foreach (string File in files)
                    {
                        Console.WriteLine(File);
                    }

                }
                catch
                {
                    Console.WriteLine("Какая-то ошибка");
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                DoAny p = new DoAny();
            }
        }
    /*static void Main(string[] args)
    {

        /*string path = @"E:\t2.txt";
        string path2 = @"E:\K2\t2.txt";
        string pathOfBackup = @"E:\t2TXFI.txt";
        try
        {

            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {
                File.Move(path, path2);
                Console.WriteLine("{0} was moved to {1}.", path, path2);
                // or file.MoveTo(path2);
            }

        }
        catch(IOException ex)
        {

            Console.WriteLine("Этот файл уже там есть, хотите заменить?");
            Console.WriteLine("Не волнуйтесь содержимое заменяемого файла сохранится.");
                int choiceOfUser = Convert.ToInt32(Console.ReadLine());
                if(choiceOfUser != 0)
                {
                    try
                    {
                        File.Replace(path, path2,pathOfBackup,false);

                    }
                    catch(IOException iox)
                    {
                        Console.WriteLine(iox.Message);
                    }

                }
                else
                {
                    Console.WriteLine(ex);
                }
        }
    }*/

}

