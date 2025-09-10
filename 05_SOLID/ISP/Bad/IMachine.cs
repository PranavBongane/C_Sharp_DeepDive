namespace _05_SOLID.ISP.Bad
{
    public interface IMachine
    {
        void Print();
        void Scan();
        void Fax();
    }

    public class OldPrinter : IMachine
    {
        public void Print() => Console.WriteLine("Printing...");
        public void Scan() => throw new NotImplementedException();
        public void Fax() => throw new NotImplementedException();
    }
}