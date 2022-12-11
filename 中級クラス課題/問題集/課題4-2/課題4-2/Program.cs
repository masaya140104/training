using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace 課題4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = args[0];

            List<string[]> fileData = readFile(fileName);

            int average = doAverage(fileData);

            Console.WriteLine(average.ToString());

            Console.ReadLine();
        }


        private static List<string[]> readFile(string fileName)
        {
            List<string[]> fileData = new List<string[]>();

            StreamReader sr = new StreamReader(fileName);
            while (-1 < sr.Peek())
            {
                string[] s = sr.ReadLine().Split(' ');
                fileData.Add(s);
            }
            sr.Close();

            return fileData;
        }

        private static int doAverage(List<string[]> fileData)
        {
            int sum = 0;
            for (int i = 0; i < fileData.Count; i++)
            {
                string[] s = fileData[i];
                for (int j = 0; j < s.Length; j++)
                {
                    sum += int.Parse(s[j]);
                }
            }
            int average = sum / fileData.Count;

            return average;
        }
    }
}
