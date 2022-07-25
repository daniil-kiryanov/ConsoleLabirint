using System;

namespace ConsoleLabirint
{
    class Program 

    {
        static void Main(string[] args)
        {
            int[,] labyrint = ProgramInput.InputData();
            ProgramOutput.OutputData(labyrint);
        }
    }
}
