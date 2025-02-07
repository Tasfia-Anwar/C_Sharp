using System;

class StringOperations
{
    static void Main()
    {
        // Example strings
        string str1 = "Hello";
        string str2 = "World";
        string str3 = "Hello, World!";
        string str4 = "   Trim string!   ";

        // 1. Concatenation
        string concatenated = str1 + " " + str2;
        Console.WriteLine("Concatenated: " + concatenated);

        // 2. Substring
        string substring = str3.Substring(7, 5); // Extracts "World"
        Console.WriteLine("Substring: " + substring);

        // 3. Comparison
        bool areEqual = str1.Equals("Hello"); // Case-sensitive comparison
        Console.WriteLine("Are str1 and 'Hello' equal? " + areEqual);

        // 4. Searching
        int index = str3.IndexOf("World"); // Finds the index of "World"
        Console.WriteLine("Index of 'World': " + index);

        // 5. Splitting
        string[] splitStrings = str3.Split(','); // Splits at the comma
        Console.WriteLine("Split Strings:");
        foreach (string s in splitStrings)
        {
            Console.WriteLine(s.Trim()); // Trim to remove extra spaces
        }

        // 6. Trimming
        string trimmed = str4.Trim(); // Removes leading and trailing spaces
        Console.WriteLine("Trimmed: " + trimmed);

        // 7. Replacing
        string replaced = str3.Replace("World", "C#"); // Replaces "World" with "C#"
        Console.WriteLine("Replaced: " + replaced);

        // 8. Case Conversion
        string upperCase = str1.ToUpper(); // Converts to uppercase
        string lowerCase = str2.ToLower(); // Converts to lowercase
        Console.WriteLine("Uppercase: " + upperCase);
        Console.WriteLine("Lowercase: " + lowerCase);

        // 9. Checking for Null or Empty
        bool isNullOrEmpty = String.IsNullOrEmpty(""); // Checks if string is null or empty
        Console.WriteLine("Is string null or empty? " + isNullOrEmpty);

        // 10. Length of a String
        int length = str3.Length; // Gets the length of the string
        Console.WriteLine("Length of str3: " + length);

        // 11. Contains
        bool contains = str3.Contains("Hello"); // Checks if string contains a substring
        Console.WriteLine("Does str3 contain 'Hello'? " + contains);
    }
}