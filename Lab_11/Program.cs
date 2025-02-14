/* Public and Private*/

// using System;

// class Car
// {
//     private string brand = "Tesla";
//     public string new_brand = "Ford";

//     private void ShowBrand()
//     {
//         Console.WriteLine("Car Brand: " + brand);
//     }

//     public void ShowNewBrand()
//     {
//         Console.WriteLine("Car Brand: " + brand);
//         Console.WriteLine("New Car Brand: " + new_brand);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Car myCar = new Car();
//         myCar.ShowNewBrand();
//         //myCar.ShowBrand();
//     }
// }


/* Internal Access Modifier */

// using System;

// class Car
// {
//     internal string brand = "Tesla"; // Internal variable

//     internal void DisplayBrand()
//     {
//         Console.WriteLine("Car Brand: " + brand);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Car myCar = new Car();
//         myCar.DisplayBrand(); // Accessible within the same assembly
//         Console.WriteLine(myCar.brand);  // Accessible
//     }
// }


using System;

class BankAccount
{
    string name;
    int balance;

    static void Main()
    {
        BankAccount myAccount = new BankAccount();

        myAccount.name = "Ajex";
        myAccount.balance = 5000;

        Console.WriteLine(myAccount.name + " " + myAccount.balance);
    }
}