using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
//                                --- This is my C# starting baseplate ---
//            --- It is made for me cuz im lazy and copy pasting code snippets is easier ---
//namespace Name_of_program
class Program
{
    static void CopyPaste()
    {
        //colors cuz cool - > https://raw.githubusercontent.com/fidian/ansi/master/images/color-codes.png
        string RESET = "\x1b[0m";
        string green_color = "\x1b[38;5;40m";
        string blue_color = "\x1b[38;5;12m";
        string red_color = "\x1b[38;5;196m";
        string yellow_color = "\x1b[38;5;226m";

        string program_name = $"[{blue_color}Custom Human Debug{RESET}]";
        string info = $"[{green_color}INF{RESET}]";
        string error = $"[{red_color}ERR{RESET}]";
        string warning = $"[{yellow_color}WRN{RESET}]";

        string Func_Readline = Console.ReadLine();

        int length = 0;
        int rowI = 2;//amuda ^ 0
        int collumn_ = 3;//shura > 1

        int[] arr = new int[length];
        int[,] matrix = new int[rowI, collumn_];
        // matrix.GetLength(1) -> collumn
        // matrix.GetLength(0) -> row
        //int num = int.Parse(Console.ReadLine());

        //input order
        //1 2 3
        //4 5 6
        for (int FrowI = 0; FrowI < matrix.GetLength(0); FrowI++)
        {
            for (int Fcollumn_ = 0; Fcollumn_ < matrix.GetLength(1); Fcollumn_++)
            {
                Console.WriteLine($"ROW {FrowI}    COL {Fcollumn_}");
                matrix[FrowI, Fcollumn_] = int.Parse(Func_Readline);
            }
        }
        //debug - write the whole matrix
        for (int FrowI = 0; FrowI < matrix.GetLength(0); FrowI++)
        {
            for (int Fcollumn_ = 0; Fcollumn_ < matrix.GetLength(1); Fcollumn_++)
            {
                Console.Write(matrix[FrowI, Fcollumn_]);
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {

    }
}
