using System;

public class FinalTotal
{
    public static void Main(string[] args)
    {
        int total = 10;
        
        Console.Write("Enter an integer: ");
        int integer = int.Parse(Console.ReadLine());

        if (integer > 0)
        {
            if (integer % 2 == 0)
            {
                Console.WriteLine("The number is even.");
                total += (integer * integer);
            }
            else
            {
                Console.WriteLine("The number is odd.");
                total += (integer * integer * integer);
            }
            Console.WriteLine(total);
        }
        else if (integer < 0)
        {
            Console.Write("Enter another integer: ");
            int exponent = int.Parse(Console.ReadLine());
            total += (int)Math.Pow(integer, exponent);
            Console.Write(total);
        }
        else
        {
            Console.WriteLine("Nothing happened.");
        }
    }
}
