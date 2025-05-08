using System;

class SampleClass
{
    public SampleClass()
    {
        Console.WriteLine("Constructor: Object created.");
    }

    // Destructor
    ~SampleClass()
    {
        Console.WriteLine("Destructor: Object is being destroyed.");
    }

    public void DisplayMessage()
    {
        Console.WriteLine("Hello from SampleClass!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SampleClass obj = new SampleClass();
        obj.DisplayMessage();

        obj = null;
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.ReadLine();

        Console.WriteLine("Main method complete.");
    }
}
