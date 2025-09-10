using _05_SOLID.SRP.Bad;
using _05_SOLID.SRP.Good;
using _05_SOLID.OCP.Bad;
using _05_SOLID.OCP.Good;
using _05_SOLID.LSP.Bad;
using _05_SOLID.LSP.Good;
using _05_SOLID.ISP.Bad;
using _05_SOLID.ISP.Good;
using _05_SOLID.DIP.Bad;
using _05_SOLID.DIP.Good;

Console.WriteLine("=== SOLID Principles Demo ===\n");

// 1. SRP
Console.WriteLine("SRP:");
var badAccount = new _05_SOLID.SRP.Bad.BankAccount();
badAccount.Deposit(100);
badAccount.Log("Deposited money (Bad Example)");

var goodAccount = new _05_SOLID.SRP.Good.BankAccount();
goodAccount.Deposit(100);
new Logger().Log("Deposited money (Good Example)");
Console.WriteLine("--------------------");

// 2. OCP
Console.WriteLine("OCP:");
new PaymentProcessor().Process("CreditCard", 200);
PaymentMethod method = new CreditCard();
method.Pay(200);
Console.WriteLine("--------------------");

// 3. LSP
Console.WriteLine("LSP:");
Bird badBird = new _05_SOLID.LSP.Bad.Ostrich();
try { badBird.Fly(); } catch { Console.WriteLine("Error: Ostrich can't fly (Bad Example)"); }

Bird goodBird1 = new Sparrow();
Bird goodBird2 = new _05_SOLID.LSP.Good.Ostrich();
goodBird1.Move();
goodBird2.Move();
Console.WriteLine("--------------------");

// 4. ISP
Console.WriteLine("ISP:");
IMachine badPrinter = new OldPrinter();
try { badPrinter.Fax(); } catch { Console.WriteLine("Error: Old printer can't fax (Bad Example)"); }

IPrinter printer = new ModernPrinter();
IScanner scanner = new ModernPrinter();
printer.Print();
scanner.Scan();
Console.WriteLine("--------------------");

// 5. DIP
Console.WriteLine("DIP:");
var badNotification = new _05_SOLID.DIP.Bad.Notification();
badNotification.Send("Hello (Bad Example)");

var emailNotification = new _05_SOLID.DIP.Good.Notification(new EmailService());
emailNotification.Send("Hello via Email");

var smsNotification = new _05_SOLID.DIP.Good.Notification(new SMSService());
smsNotification.Send("Hello via SMS");
Console.WriteLine("--------------------");

Console.WriteLine("\n=== Demo Finished ===");
Console.ReadKey();
