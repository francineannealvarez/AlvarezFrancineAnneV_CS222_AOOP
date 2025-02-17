using System;

public class InterestCalculator
{
    public static void Main(string[] args)
    {
        Console.Write ("Enter principal amount: ");
        double principalAmount = double.Parse(Console.ReadLine());
        Console.Write ("Enter rate of interest: ");
        double interestRate = double.Parse(Console.ReadLine());
        Console.Write ("Enter time in years: ");
        double time = double.Parse(Console.ReadLine());

        double simpleInterest = (principalAmount * interestRate * time) / 100;
        Console.WriteLine ("Simple Interest: {0:F2}", simpleInterest);
    }
}