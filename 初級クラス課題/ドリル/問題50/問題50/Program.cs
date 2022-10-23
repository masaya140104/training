using System;
using System.Text;
using System.IO;

namespace 問題50
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\tsubo\source\repos\training\初級クラス課題\ドリル\問題50\numbers.txt", Encoding.UTF8);

            string number = sr.ReadToEnd();

            sr.Close();

            StreamWriter sw = new StreamWriter(@"C:\Users\tsubo\source\repos\training\初級クラス課題\ドリル\問題50\numbers_odd.txt", false, Encoding.UTF8);

            sw.Write(number.ToString());

            sw.Close();

            Console.ReadLine();
        }
    }
}
