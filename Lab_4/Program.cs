using System; 

class RecursiveFibonacci
{
    static void Main()
    {
        Console.Write("Enter the value of n to calculate the nth Fibonacci number: ");
        int n = int.Parse(Console.ReadLine());
        
        int result = Fibonacci(n);

        Console.WriteLine($"The {n}th Fibonacci number is: {result}");
    }

    static int Fibonacci(int n)
    {
        // Base cases: Fibonacci(0) = 0, Fibonacci(1) = 1
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;

        // Recursive case: Fibonacci(n) = Fibonacci(n-1) + Fibonacci(n-2)
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

}