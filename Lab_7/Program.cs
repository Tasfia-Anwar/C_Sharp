using System;

class Program
{
    static void Main()
    {
        // Using a for loop to print numbers from 1 to 10
        Console.WriteLine("Numbers from 1 to 10 and their even/odd status:");

        for (int i = 1; i <= 10; i++) // Loop from 1 to 10
        {
            if (i % 2 == 0) // Check if the number is even
            {
                Console.WriteLine(i + " is Even");
            }
            else // If not even, it must be odd
            {
                Console.WriteLine(i + " is Odd");
            }
        }
    }
}
