namespace _05_SOLID.ISP.Good
{
    public interface IPrinter
    {
        void Print();
    }

    public interface IScanner
    {
        void Scan();
    }

    public class ModernPrinter : IPrinter, IScanner
    {
        public void Print() => Console.WriteLine("Printing...");
        public void Scan() => Console.WriteLine("Scanning...");
    }
}