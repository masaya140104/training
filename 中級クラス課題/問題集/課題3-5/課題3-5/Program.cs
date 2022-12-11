using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 課題3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = readFile();
            int result = sum(list);
            Console.WriteLine("合計は" + result.ToString()+ "です。");

            Console.ReadLine();
        }

        private static List<string> readFile()
        {           
            StreamReader sr = new StreamReader(@"C:\Users\Public\Documents\figureRow.txt", Encoding.UTF8);

            List<string> list = new List<string>();
            while (-1 <sr.Peek())
            {
                list.Add(sr.ReadLine());
            }
            sr.Close();

            return list;
        }

        private static int sum(List<string> list)
        {
            int result = 0;

            for (int i = 0; i < list.Count; i++)
            {
                result += int.Parse(list[i]);
            }

            return result;
        }

        
    }
}
