
using System;
public class SumOfnNumber
{
    static int Sum (int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else 
        {
            return (n + Sum (n - 1));
        }
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter value of n: ");
        int num = int.Parse(Console.ReadLine());
        int sum = Sum(num)/10;
        Console.WriteLine("Sum: {0:F2}", sum);
    }
}