        int rows = 4;
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= rows - 1; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("*");
        }