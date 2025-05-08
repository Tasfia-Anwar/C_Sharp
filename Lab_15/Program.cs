using System;

public interface IPayment
{
    void ProcessPayment(int amount);
}

public interface IRefund
{
    void ProcessRefund(int amount);
}

public interface ILogger
{
    void LogTransaction(string message);
}

public class PayPalPaymentProcessor : IPayment, IRefund, ILogger
{
    public void ProcessPayment(int amount)
    {
        Console.WriteLine($"[PayPal] Processed payment of ${amount}");
        LogTransaction($"Payment of ${amount} processed.");
    }

    public void ProcessRefund(int amount)
    {
        Console.WriteLine($"[PayPal] Refunded ${amount}");
        LogTransaction($"Refund of ${amount} processed.");
    }

    public void LogTransaction(string message)
    {
        Console.WriteLine($"[PayPal] Log: {message}");
    }
}

class Program
{
    static void Main()
    {
        PayPalPaymentProcessor paypal = new PayPalPaymentProcessor();

        paypal.ProcessPayment(100);
        paypal.ProcessRefund(25);

        // Interface-based usage
        IPayment payment = paypal;
        payment.ProcessPayment(50);

        IRefund refund = paypal;
        refund.ProcessRefund(10);

        ILogger logger = paypal;
        logger.LogTransaction("Manual transaction logged.");
    }
}
