using System;

class Car
{
    //Properties or atribute
    public string brand;
    public int year; 
    private string new_brand = "Ford";

    private void ShowBrand()
    {
        Console.WriteLine("New Brand: "+ new_brand);
    }


    //Method
    public void DisplayInfor()
    {
        Console.WriteLine($"Car Brand: {brand}");
        Console.WriteLine($"Car year: {year}");
        Console.WriteLine("New Brand: "+ new_brand);
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car();

        car1.brand = "Tesla";
        car1.year = 2020;
        

        car1.DisplayInfor();
    }
}