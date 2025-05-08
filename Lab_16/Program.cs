using System;

public interface IUser
{
    string Username { get; set; }
    string Email { get; set; }
    int Age { get; }
}

public class BasicUser : IUser
{
    public string Username { get; set; }
    public string Email { get; set; }

    private DateTime birthDate;

    public BasicUser(string username, string email, DateTime birthDate)
    {
        Username = username;
        Email = email;
        this.birthDate = birthDate;
    }

    public int Age
    {
        get
        {
            var today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age)) age--;
            return age;
        }
    }
}

class Program
{
    static void Main()
    {
        IUser user = new BasicUser("x", "x@example.com", new DateTime(2000, 5, 10));

        Console.WriteLine($"Username: {user.Username}");
        Console.WriteLine($"Email: {user.Email}");
        Console.WriteLine($"Age: {user.Age}");

        // Update property through interface
        user.Email = "new_email@example.com";
        Console.WriteLine($"Updated Email: {user.Email}");
    }
}
