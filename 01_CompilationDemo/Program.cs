using System;

namespace _01_CompilationDemo
{
    public class Program
    {
        public static int Add(int a, int b) => a + b;

        public static void Main()
        {
            int result = Add(10, 20);
            Console.WriteLine($"Result: {result}");
        }
    }
}
