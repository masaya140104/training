﻿using System;

namespace 問題43
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] tvProgram = {{ "NHK", "ニュース" }, { "NHK教育", "料理番組" },
                                  { "日本テレビ", "バラエティ" }, { "TBS", "ドラマスペシャル" },
                                  { "フジテレビ", "ドラマ" }, { "テレビ朝日", "ニュースバラエティ" }};


            for (int i = 0; i < tvProgram.Length / 2; i++)
            {
                Console.WriteLine(tvProgram[i,0] + "：" + tvProgram[i, 1]);
            }

            Console.ReadLine();
        } 
    }
}
