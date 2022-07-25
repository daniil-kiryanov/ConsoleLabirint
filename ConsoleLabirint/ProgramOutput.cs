namespace ConsoleLabirint
{
    class ProgramOutput
    {

        public static void OutputData(int[,] labyrint)
        {
            while (true)
            {
                for (int i = 0; i < labyrint.GetLength(0); i++)
                {
                    for (int j = 0; j < labyrint.GetLength(1); j++)
                    {
                        Console.Write($"{labyrint[i, j]}");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
                break;
            }
        }
    }
}