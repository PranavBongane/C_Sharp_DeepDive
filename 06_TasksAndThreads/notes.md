🧵 Tasks & Threads in C# — Console App Demo
🎯 Purpose

This project demonstrates how to use Threads, Tasks, and async/await in C# for concurrent and parallel programming.
It’s designed for developers preparing for .NET interviews or building AI-ready backend apps where concurrency matters.

📘 Concept Overview
Concept	Description	Example Use Case
Thread	A low-level unit of execution that runs code in parallel.	Running background processes manually.
Task	A higher-level abstraction built on threads, supporting async/await.	Running database calls or API requests concurrently.
Async/Await	Simplifies asynchronous programming — avoids blocking the main thread.	File uploads, data processing, web requests.
lock	Prevents race conditions when multiple threads modify shared data.	Managing counters or shared resources safely.

⚙️ Features Demonstrated

Thread Demo

Create and start threads manually using ThreadStart.

Use Join() to wait for threads to finish.

Task Demo (Async/Await)

Run asynchronous work using Task.Run().

Wait for multiple tasks with Task.WhenAll().

Observe non-blocking execution.

Parallel Task Demo (Synchronization)

Demonstrates how multiple tasks safely increment shared data using lock.

💻 Code Structure
TasksAndThreadsDemo/
│
├── Program.cs        # Main demo code (Threads, Tasks, Parallel)
└── README.md         # Documentation

🧠 Key Learnings
Concept	Code Snippet
Creating a Thread	Thread t = new Thread(() => DoWork());
Starting a Task	Task.Run(() => ComputeSquare(5));
Waiting for All Tasks	await Task.WhenAll(task1, task2);
Thread Safety (lock)	lock(locker) { total++; }
⚡ Sample Output
=== Tasks & Threads Demo ===

--- THREAD DEMO ---
Thread-1 → 1
Thread-2 → 1
Threads finished execution.

--- TASK DEMO ---
Computing square for 5 on Thread 6
Computing square for 8 on Thread 7
Task results: 25, 64
Async tasks completed.

--- PARALLEL TASK DEMO (with lock) ---
Task-1 incremented total → 1
Task-2 incremented total → 2
Final total (after lock protection): 10

🌍 Real-World Use Cases
Scenario	Description
📨 Email Sending	Use Task.Run() to send multiple emails simultaneously.
🧮 AI Model Inference	Run parallel model predictions on multiple inputs.
🧾 File Processing	Process several files concurrently using Tasks.
🌐 Web Requests	Call multiple APIs without blocking the main thread.
🧩 Run the Project

# Navigate to folder
cd TasksAndThreadsDemo

# Run
dotnet run



🧭 Author

Pranav M. Bongane