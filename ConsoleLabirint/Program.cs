using System;

namespace ConsoleLabirint
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] labyrint = new int[,]
            {
                {1,1,1,1,0,1,1,1,1,1},
                {1,0,1,1,0,1,0,0,0,1},
                {1,0,0,0,0,1,0,1,0,1},
                {1,1,1,1,0,1,0,1,0,1},
                {0,0,0,0,0,1,0,1,0,1},
                {1,1,0,1,1,1,0,1,0,1},
                {1,1,0,0,0,0,0,1,0,1},
                {1,1,1,1,1,1,1,1,0,1},
                {1,0,0,0,0,0,0,0,0,1},
                {1,1,1,1,1,1,0,1,1,1}
            };
            while (true)
            {
                for (int i = 0; i < labyrint.GetLength(0); i++)
                {
                    for (int j = 0; j < labyrint.GetLength(1); j++)
                    {
                        if (labyrint[i, j] == 0) Console.Write("0");
                        if (labyrint[i, j] == 1) Console.Write("1");

                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}
