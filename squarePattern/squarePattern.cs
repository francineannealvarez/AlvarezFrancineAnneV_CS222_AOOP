using System;

class SquarePattern
{
    public static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        int y = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++ )
        {
            if (i == y)
            {
                Console.WriteLine();
                continue;
            }

            for (int j = 0; j < n; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine(" ");
        }
    }
}



