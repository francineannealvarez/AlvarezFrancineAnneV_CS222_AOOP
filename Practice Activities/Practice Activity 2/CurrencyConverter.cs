using System;

public class CurrencyConverter
{
    public static void Main(string[] args)
    {
        Console.Write ("Enter amount in USD: ");
        double amount = double.Parse(Console.ReadLine());
        Console.Write ("Enter exchange rate from USD to EUR: ");
        double exchangeRate = double.Parse(Console.ReadLine());

        double convertedAmount = amount * exchangeRate;
        Console.WriteLine ("Amount in EUR: {0:F2}", convertedAmount);
    }
}