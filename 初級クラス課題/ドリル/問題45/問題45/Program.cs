using System;

namespace 問題45
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] tvProgram = {{ "1", "ニュース" }, { "3", "料理番組" }, { "4", "バラエティ" },
                                    { "6", "ドラマスペシャル" }, { "8", "ドラマ" },
                                    { "10", "ニュースバラエティ" }};

            Console.WriteLine("チャンネルを入力してください。（1, 3, 4, 6, 8, 10)");

            int channel = int.Parse(Console.ReadLine());

            Console.WriteLine("指定されたチャンネルは・・・");

            for (int i = 0; i < tvProgram.GetLength(0); i++)
            {
                if (channel == int.Parse(tvProgram[i, 0]))
                {
                    Console.WriteLine(tvProgram[i, 0] + "：" + tvProgram[i, 1]);
                }
            }
            
            Console.ReadLine();
        }
    }
}
