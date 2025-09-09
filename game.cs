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

        Random rand = new Random();

        // Place the objective randomly on the grid
        int ObjectX = rand.Next(0, screen.Length);            // row
        int ObjectY = rand.Next(0, screen[0].Length);         // column

        int PlayerX = 0;
        int PlayerY = 0;

        void DrawScreen()
        {
            Console.Clear();
            for (int x = 0; x < screen.Length; x++)
            {
                for (int y = 0; y < screen[x].Length; y++)
                {
                    if (x == PlayerX && y == PlayerY)
                        Console.Write("# ");   // player
                    else if (x == ObjectX && y == ObjectY)
                        Console.Write("X ");   // objective -> we make it so that the object x and the x is the same and we do the same for y
                    else if (screen[x][y] % 2 != 0)
                        Console.Write("|| ");  // walls (odd numbers)
                    else
                        Console.Write("  ");   // empty
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Player at: ({PlayerX},{PlayerY})");
            Console.WriteLine($"Objective at: ({ObjectX},{ObjectY})");
        }

        while (true)
        {
            DrawScreen();
            // Win condition
            if (PlayerX == ObjectX && PlayerY == ObjectY)
            {
                Console.WriteLine("You reached the objective!");
                break;
            }

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
                break;
        }
    }
}
