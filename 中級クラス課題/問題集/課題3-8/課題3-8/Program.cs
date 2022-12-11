using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 課題3_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string[]> list = readFile();
            int result = count(list);
            Console.WriteLine("柴犬は" + result.ToString() + "です。");
            Console.ReadLine();
        }

        private static List<string[]> readFile()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Public\Documents\inu.txt", Encoding.UTF8);
            
            List<string[]> list = new List<string[]>();
            
            while (-1 < sr.Peek())
            {
                string[] s = sr.ReadLine().Split(' ');
                list.Add(s);
            }

            sr.Close();
            
            return list;
        }

        private static int count(List<string[]> list)
        {
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                string[] s = list[i];
                
                for (int j = 0; j < s.Length; j++)
                {
                    if(s[j] == "柴犬")
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
