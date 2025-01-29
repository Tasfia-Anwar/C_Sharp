// using System;This line includes the System namespace, which contains fundamental classes for basic operations in C#, such as input/output, data types, and more.
// The Console.WriteLine method used later in the code is part of the System namespace.

// namespace MyApp
// A namespace is a container for classes and other types, used to organize code and avoid naming conflicts.
// Here, MyApp is the name of the namespace, and it contains the program's class and methods.

// The Program class is where the program logic is defined.

// A static class can only contain static data members, static methods, and a static constructor. 
// It is not allowed to create objects of the static class. 
// Static classes are sealed, means one cannot inherit a static class from another class.


// Console: A class in the System namespace used for standard input, output, and error streams.
// WriteLine: A method of the Console class that writes the specified text to the console followed by a newline.

using System;

namespace MyApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            int a  =10;
            int b = 20;
            Console.WriteLine(a + b);
        }
    }
}