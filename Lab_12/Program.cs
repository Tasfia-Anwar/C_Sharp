// class BankAccount {
//     private string name;
//     private double balance;

//     // Property for Name with get and set
//     public string Name {
//         get { return name; }
//         set { name = value; }
//     }

//     // Property for Balance with get and set
//     public double Balance {
//         get { return balance; }
//         set { balance = value; }
//     }

//     // Parameterized Constructor
//     public BankAccount(string name, double balance) {
//         this.Name = name;
//         this.Balance = balance;
//     }
// }
// // Usage: Shallow Copy Example
// class Program {
//     static void Main() {
//         // Create the first BankAccount object
//         BankAccount account1 = new BankAccount("ABC", 1000.00);

//         // Create a shallow copy of account1 by assignment (not using a copy constructor)
//         BankAccount account2 = account1; // Shallow copy: account2 references the same memory as account1

//         // Modify account2's Balance
//         account2.Balance = 500.00;

//         // Output the balances of both account1 and account2
//         Console.WriteLine("Account 1 Balance: " + account1.Balance); // Output: 500.00
//         Console.WriteLine("Account 2 Balance: " + account2.Balance); // Output: 500.00
//     }
// }




















class BankAccount {
    private string name;
    private double balance;

    public string Name {
        get { return name; }
        set { name = value; }
    }

    public double Balance {
        get { return balance; }
        set { balance = value; }
    }

    public BankAccount(string name, double balance) {
        this.Name = name;
        this.Balance = balance;
    }

    // Copy Constructor (Deep Copy)
    public BankAccount(BankAccount oldAccount) {
        this.Name = oldAccount.Name;       // Copying the value of Name
        this.Balance = oldAccount.Balance; // Copying the value of Balance
    }
}


class Program {
    static void Main() {
        // Create the first BankAccount object
        BankAccount account1 = new BankAccount("ABC", 1000.00);

        // Create deep copy of account1 using copy constructor
        BankAccount account2 = new BankAccount(account1); // Deep copy: account2 is independent of account1

        // Modify account2's Balance
        account2.Balance = 500.00;

        // Output the balances of both account1 and account2
        Console.WriteLine("Account 1 Balance: " + account1.Balance); // Output: 1000.00 (Unchanged)
        Console.WriteLine("Account 2 Balance: " + account2.Balance); // Output: 500.00 (Modified)
    }
}

