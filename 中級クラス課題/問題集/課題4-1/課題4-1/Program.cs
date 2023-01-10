using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 課題4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = args[0];

            StreamReader sr = new StreamReader(fileName);
            string fileData = sr.ReadToEnd();
            sr.Close();

            Console.Write(fileData);

            Console.ReadLine();
        }
    }
}
