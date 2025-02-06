using System;

class Program1
{
    static void Main()
    {
        // Integer types
        int myInt = 42;
        short myShort = 100;
        long myLong = 1234567890123456789;

        // Floating-point types
        float myFloat = 3.14f; // 'f' suffix for float
        double myDouble = 3.141592653589793;
        decimal myDecimal = 3.14159265358979323846m; // 'm' suffix for decimal

        // Boolean type
        bool myBool = true;

        // Character type
        char myChar = 'A';

        // String type (reference type)
        string myString = "Hello, C#!";

        // Output values
        Console.WriteLine("int: {myInt}");
        Console.WriteLine($"short: {myShort}");
        Console.WriteLine($"long: {myLong}");
        Console.WriteLine($"float: {myFloat}");
        Console.WriteLine($"double: {myDouble}");
        Console.WriteLine($"decimal: {myDecimal}");
        Console.WriteLine($"bool: {myBool}");
        Console.WriteLine($"char: {myChar}");
        Console.WriteLine($"string: {myString}");
    }
}

using System;

class Program2
{
    static void Main()
    {
        int x = 10;
        int y = 20;

        Console.WriteLine($"Equal: {x == y}");         // False
        Console.WriteLine($"Not Equal: {x != y}");     // True
        Console.WriteLine($"Greater Than: {x > y}");   // False
        Console.WriteLine($"Less Than: {x < y}");      // True
        Console.WriteLine($"Greater or Equal: {x >= y}"); // False
        Console.WriteLine($"Less or Equal: {x <= y}"); // True
    }
}

using System;

class Program3
{
    static void Main()
    {
        bool a = true;
        bool b = false;

        Console.WriteLine($"AND: {a && b}"); // False
        Console.WriteLine($"OR: {a || b}");  // True
        Console.WriteLine($"NOT: {!a}");     // False
    }
}

using System;

class Program4
{
    static void Main()
    {
        int x = 10;
        x += 5; // Equivalent to x = x + 5
        Console.WriteLine($"+= Operator: {x}"); // 15

        x -= 3; // Equivalent to x = x - 3
        Console.WriteLine($"-= Operator: {x}"); // 12

        x *= 2; // Equivalent to x = x * 2
        Console.WriteLine($"*= Operator: {x}"); // 24

        x /= 4; // Equivalent to x = x / 4
        Console.WriteLine("/= Operator: " + x); // 6
    }
}

using System;

class Program5
{
    static void Main()
    {
        int age = 17;
        string status = (age >= 18) ? "Adult" : "Minor";
        Console.WriteLine($"Status: {status}"); // Adult
    }
}

using System;

class Program6
{
    static void Main()
    {
        // Input values
        string input1 = "10";
        string input2 = "3.5";

        // Convert strings to numeric types
        int num1 = int.Parse(input1);
        double num2 = double.Parse(input2);

        // Perform arithmetic operations
        double sum = num1 + num2;
        double product = num1 * num2;

        // Output results
        Console.WriteLine($"Sum: {sum}");         // 13.5
        Console.WriteLine($"Product: {product}"); // 35.0

        // Ternary operator example
        string result = (sum > 10) ? "Greater than 10" : "Less than or equal to 10";
        Console.WriteLine($"Result: {result}");   // Greater than 10
    }
}