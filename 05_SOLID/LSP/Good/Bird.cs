namespace _05_SOLID.LSP.Good
{
    public abstract class Bird
    {
        public abstract void Move();
    }

    public class Sparrow : Bird
    {
        public override void Move() => Console.WriteLine("Sparrow is flying...");
    }

    public class Ostrich : Bird
    {
        public override void Move() => Console.WriteLine("Ostrich is running...");
    }
}