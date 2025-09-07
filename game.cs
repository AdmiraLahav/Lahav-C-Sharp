using System;

class Game
{
    static void Main(string[] args)
    {
        int[][] screen = {
            new[] {  2,  4,  6,  8, 10, 12, 14, 16, 18, 20 },
            new[] { 22, 24, 26, 28, 30, 32, 34, 36, 38, 40 },
            new[] { 42, 44, 46, 48, 50, 52, 54, 56, 58, 60 },
            new[] { 62, 64, 66, 68, 70, 72, 74, 76, 78, 80 },
            new[] { 82, 84, 86, 88, 90, 92, 94, 96, 98,100 },
            new[] {102,104,106,108,110,112,114,116,118,120 },
            new[] {122,124,126,128,130,132,134,136,138,140 },
            new[] {142,144,146,148,150,152,154,156,158,160 },
            new[] {162,164,166,168,170,172,174,176,178,180 },
            new[] {182,184,186,188,190,192,194,196,198,200 }
        };

        int PlayerY = 0;
        int PlayerX = 0;

        void DrawScreen()
        {
            //we clear the screen to create the most up to date one
            Console.Clear();
            for (int X = 0; X < screen.Length; X++)
            {
                for (int Y = 0; Y < screen[X].Length; Y++)
                {
                    if (X == PlayerX && Y == PlayerY)
                        Console.Write("# ");
                    else if (screen[X][Y] % 2 != 0)
                        Console.Write("|| ");
                    else
                        Console.Write("  ");//double space
                }
                Console.WriteLine();
            }
            Console.WriteLine("X Cord is " + PlayerY + "    Y Cord is " + PlayerX);
        }
        // while true (always) read the user inputed key
        while (true)
        {
            //call to draw screen func, which first deletes teh screen, and tehn reads a key
            DrawScreen();
            var key = Console.ReadKey(true).KeyChar;
            if (key == 'd' && PlayerY < screen[0].Length - 1)
                PlayerY++;
            else if (key == 'a' && PlayerY > 0)
                PlayerY--;
            else if (key == 'w' && PlayerX > 0)
                PlayerX--;
            else if (key == 's' && PlayerX < screen.Length - 1)
                PlayerX++;
            else if (key == 'q')
                break; // Press 'q' to quit
        }
    }
}
