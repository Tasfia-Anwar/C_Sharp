using System;

class PalindromeChecker
{
    static void Main()
    {
    Console.Write("Enter a String: ");
    string str = Console.ReadLine();

    if(IsPalindrome(str))
    {
        Console.WriteLine($"'{str}' is a palindrome");
    }
    else 
    {
        Console.WriteLine($"'{str}' is not a palindrome");
    }
    }

    static bool IsPalindrome(string str)
    {
        str = str.Replace(" ","").ToLower();

        int left = 0;
        int right = str.Length-1;

        while(left<right)
        {
            if(str[left]!=str[right])return false;
            left++;
            right--;
        }
        return true;
    }
}