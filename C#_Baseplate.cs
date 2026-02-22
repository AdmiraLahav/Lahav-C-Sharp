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
    static void Copy_Paste()
    {
        int length = 0;
        int rowI = 2;//amuda ^ 0
        int collumn_ = 3;//shura > 1
                         // || amuda
                         // -- shura
        int[] arr = new int[length];
        int[,] matrix = new int[rowI, collumn_];
        // matrix.GetLength(1) -> collumn
        // matrix.GetLength(0) -> row
        //int num = int.Parse(Console.ReadLine());

        Console.WriteLine($"");
        for (int FrowI = 0; FrowI < matrix.GetLength(0); FrowI++)
        {
            for (int Fcollumn_ = 0; Fcollumn_ < matrix.GetLength(1); Fcollumn_++)
            {
                Console.WriteLine($"ROW {FrowI}    COL {Fcollumn_}");
                matrix[FrowI, Fcollumn_] = int.Parse(Console.ReadLine());
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
