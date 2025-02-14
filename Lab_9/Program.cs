using System;

class Car
{
    public string brand;
    public int year;

    //Method
    public void DisplayInfo()
    {
        Console.WriteLine($"Car Brand: {brand}");
        Console.WriteLine($"Car Year: {year}");
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car();

        car1.brand = "Tesla";
        car1.year = 2020;

        car1.DisplayInfo();
    }
}