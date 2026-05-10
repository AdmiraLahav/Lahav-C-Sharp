using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
//                                --- This is my C# starting baseplate ---
//            --- It is made for me cuz im lazy and copy pasting code snippets is easier ---
//namespace Name_of_program
class PublicVariables
{
    public string Name;
    public string Weight;
    public string Hight;
}
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

        int length = 0;
        int rowI = 2;//amuda ^ 0
        int collumn_ = 3;//shura > 1

        int[] array = new int[length];
        int[,] matrix = new int[rowI, collumn_];
        // matrix.GetLength(1) -> collumn
        // matrix.GetLength(0) -> row
        //int num = int.Parse(Console.ReadLine());

        //input order
        //1 2 3
        //4 5 6
        for (int for_rowI = 0; for_rowI < matrix.GetLength(0); for_rowI++)
        {
            for (int for_collumn_ = 0; for_collumn_ < matrix.GetLength(1); for_collumn_++)
            {
                Console.WriteLine($"ROW {for_rowI}    COL {for_collumn_}");
                matrix[for_rowI, for_collumn_] = for_collumn_*100+for_rowI;
            }
        }
        //debug - write the whole matrix
        for (int for_rowI = 0; for_rowI < matrix.GetLength(0); for_rowI++)
        {
            for (int for_collumn_ = 0; for_collumn_ < matrix.GetLength(1); for_collumn_++)
            {
                Console.Write(matrix[for_rowI, for_collumn_]);
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {

    }
}
