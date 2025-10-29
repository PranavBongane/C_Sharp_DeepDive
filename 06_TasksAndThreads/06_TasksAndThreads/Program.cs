using System;
using System.Threading;
using System.Threading.Tasks;

namespace TasksAndThreadsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Tasks & Threads Demo ===\n");

            // 1️⃣ THREAD DEMO
            ThreadDemo();

            // 2️⃣ TASK DEMO
            TaskDemo().Wait();

            // 3️⃣ PARALLEL TASKS + SYNC
            ParallelDemo().Wait();

            Console.WriteLine("\n✅ All demos complete. Press any key to exit...");
            Console.ReadKey();
        }

        // Demonstrates basic threading
        static void ThreadDemo()
        {
            Console.WriteLine("--- THREAD DEMO ---");

            // Create a thread using ThreadStart
            Thread t1 = new Thread(() => PrintNumbers("Thread-1"));
            Thread t2 = new Thread(() => PrintNumbers("Thread-2"));

            t1.Start();
            t2.Start();

            t1.Join(); // Wait for completion
            t2.Join();

            Console.WriteLine("Threads finished execution.\n");
        }

        static void PrintNumbers(string threadName)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{threadName} → {i}");
                Thread.Sleep(300);
            }
        }

        // Demonstrates async Tasks
        static async Task TaskDemo()
        {
            Console.WriteLine("--- TASK DEMO ---");

            Task<int> task1 = Task.Run(() => ComputeSquare(5));
            Task<int> task2 = Task.Run(() => ComputeSquare(8));

            int[] results = await Task.WhenAll(task1, task2);

            Console.WriteLine($"Task results: {string.Join(", ", results)}");
            Console.WriteLine("Async tasks completed.\n");
        }

        static int ComputeSquare(int number)
        {
            Console.WriteLine($"Computing square for {number} on Thread {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
            return number * number;
        }

        // Demonstrates parallel tasks and locking
        static async Task ParallelDemo()
        {
            Console.WriteLine("--- PARALLEL TASK DEMO (with lock) ---");

            object locker = new object();
            int total = 0;

            Task t1 = Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    lock (locker)
                    {
                        total++;
                        Console.WriteLine($"Task-1 incremented total → {total}");
                    }
                    Thread.Sleep(200);
                }
            });

            Task t2 = Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    lock (locker)
                    {
                        total++;
                        Console.WriteLine($"Task-2 incremented total → {total}");
                    }
                    Thread.Sleep(200);
                }
            });

            await Task.WhenAll(t1, t2);

            Console.WriteLine($"Final total (after lock protection): {total}\n");
        }
    }
}
