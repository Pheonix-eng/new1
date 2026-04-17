using System;

public class Program1
{
    public static void Main()
    {
        Console.WriteLine("Prime numbers from 1 to 100:");
        for (int num = 2; num <= 100; num++)
        {
            bool isPrime = true;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.Write(num + " ");
            }
        }

        Console.WriteLine("\n\nMultiples of 8 (1–80):");
        for (int i = 1; i <= 80; i++)
        {
            if (i % 8 == 0)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine("\n\nMultiples of 10 (1–100):");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 10 == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}