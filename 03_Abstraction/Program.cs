using _03_Abstraction;
using _03_Abstraction.PaymentContracts;

class Program
{
    static void Main(string[] args)
    {
        // ===============================
        // 🔴 BAD ABSTRACTION DEMO
        // ===============================
        Console.WriteLine("=== Bad Abstraction Demo ===");
        BadPaymentSystem badSystem = new BadPaymentSystem();

        // Passing string identifiers - fragile and error-prone
        badSystem.MakePayment("CreditCard", 500);
        badSystem.MakePayment("PayPal", 750);
        badSystem.MakePayment("UPI", 250);

        // Invalid option still compiles, but breaks at runtime
        badSystem.MakePayment("Crypto", 1000);

        Console.WriteLine("\n>>> Problems: No structure, strings are error-prone, "
                        + "and new payment methods require modifying existing code.\n");



        // ===============================
        // 🟡 GOOD ABSTRACTION DEMO (Abstract Class)
        // ===============================
        Console.WriteLine("=== Good Abstraction Demo (Abstract Class) ===");

        List<AbstractPaymentSystem> payments = new List<AbstractPaymentSystem>
        {
            new CreditCardPayment { Amount = 500 },
            new PayPalPayment { Amount = 750 },
            new UpiPayment { Amount = 250 }
        };

        foreach (var payment in payments)
        {
            Console.WriteLine($"\n[Processing {payment.GetType().Name}]");
            payment.MakePayment();   // abstract method (must be overridden)
            payment.PrintReceipt();  // shared logic from abstract class
            Console.WriteLine("----------------------");
        }

        Console.WriteLine("\n>>> Benefits: Abstract class enforces structure, "
                        + "allows shared logic (PrintReceipt), "
                        + "and is easy to extend.\n");

        Console.WriteLine("Press any key to continue to interface abstraction demo...");
        Console.ReadKey();
        Console.Clear();



        // ===============================
        // 🟢 INTERFACE ABSTRACTION DEMO
        // ===============================
        Console.WriteLine("=== Interface Abstraction Demo ===\n");

        // Note: Using separate classes (_CreditCardPayment, etc.) that implement IPayment
        List<IPayment> Ipayments = new List<IPayment>
        {
            new _CreditCardPayment { Amount = 500 },
            new _PayPalPayment { Amount = 750 },
            new _UpiPayment { Amount = 250 }
        };

        foreach (var payment in Ipayments)
        {
            Console.WriteLine($"\n[Processing {payment.GetType().Name}]");
            payment.MakePayment();   // contract from interface
            payment.PrintReceipt();  // also enforced by interface
            Console.WriteLine("---------------------------");
        }

        Console.WriteLine("\n>>> Benefits: Interface defines a pure contract, "
                        + "supports multiple inheritance, "
                        + "and works well when systems are unrelated.\n");

        Console.WriteLine("Demo finished. Press any key to exit.");
        Console.ReadKey();
    }
}
