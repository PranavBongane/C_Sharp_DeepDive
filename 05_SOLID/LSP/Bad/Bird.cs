namespace _05_SOLID.LSP.Bad
{
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Bird is flying...");
        }
    }

    public class Ostrich : Bird
    {
        public override void Fly()
        {
            // ❌ Ostriches can’t fly → violates LSP
            throw new NotImplementedException("Ostriches can't fly!");
        }
    }
}