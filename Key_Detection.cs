static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (!char.IsControl(keyInfo.KeyChar)&&!char.IsWhiteSpace(keyInfo.KeyChar))
                {
                    Console.WriteLine(keyInfo.KeyChar);
                }
                else
                {
                    Console.WriteLine(keyInfo.Key);
                }
            }
        }
