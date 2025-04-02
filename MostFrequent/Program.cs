
using System;
class Sumofnumbers
{
    static int Frequent (int size, int[] arr)
    {
        int maxCount = 0;
        int mostFrequent = arr[0];
        
        for (int i = 0; i < size; i++)
        {
            int count = 0;
            
            for(int j = 0; j < size; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                }
            }
        
        if (count > maxCount)
        {
            maxCount = count;
            mostFrequent = arr[i];
        }
    }
        return mostFrequent;
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter the size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        
        Console.WriteLine("Enter the elements of the array: ");
        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        int MostF = Frequent(size, arr);
        Console.WriteLine("Most Frequent ELement: {0}", MostF);
        
    }
}