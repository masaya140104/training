using System;
using System.Text;
using System.IO;

namespace 問題49
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ファイル名を入力してください。");

            string textName = Console.ReadLine();

            StreamWriter sw = new StreamWriter(@"C:\Users\Public\Documents" + textName, false, Encoding.UTF8);

            Random random = new Random();

            int x = 0;

            for (int i = 0; i < 10; i++)
            {
                x = random.Next(0, 100);

                sw.WriteLine(x.ToString());
            }

            sw.Close();

            Console.WriteLine("ファイルを保存しました。");

            Console.ReadLine();
        }
    }
}