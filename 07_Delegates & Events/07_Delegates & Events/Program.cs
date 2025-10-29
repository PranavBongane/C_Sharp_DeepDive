using System;

namespace DelegatesAndEvents
{
    // Step 1️⃣ — Define a delegate type
    public delegate void PrintDelegate(string message);

    // Step 2️⃣ — Publisher class (raises events)
    public class AlarmSystem
    {
        // Custom delegate-based event
        public event Action? OnAlarmTriggered;

        // Event with EventHandler pattern (standard .NET way)
        public event EventHandler<AlarmEventArgs>? AlarmRaised;

        public void TriggerAlarm(string location)
        {
            Console.WriteLine("\n🚨 Alarm Triggered!");
            OnAlarmTriggered?.Invoke();
            AlarmRaised?.Invoke(this, new AlarmEventArgs(location, DateTime.Now));
        }
    }

    // Step 3️⃣ — Custom EventArgs class
    public class AlarmEventArgs : EventArgs
    {
        public string Location { get; }
        public DateTime Time { get; }

        public AlarmEventArgs(string location, DateTime time)
        {
            Location = location;
            Time = time;
        }
    }

    // Step 4️⃣ — Subscribers
    public class SecurityTeam
    {
        public void OnAlarmRaised(object? sender, AlarmEventArgs e)
        {
            Console.WriteLine($"👮 Security Team notified! Location: {e.Location} at {e.Time:T}");
        }
    }

    public class FireDepartment
    {
        public void OnAlarmRaised(object? sender, AlarmEventArgs e)
        {
            Console.WriteLine($"🔥 Fire Dept dispatched to {e.Location} at {e.Time:T}");
        }
    }

    // Step 5️⃣ — Demo Program
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Delegates & Events Demo ===");

            // ----- Basic delegate -----
            PrintDelegate printer = PrintMessage;
            printer("Hello from a basic delegate!");

            // Multicast delegate
            printer += UpperCasePrinter;
            printer("This will be printed twice!");

            // ----- Events -----
            var alarm = new AlarmSystem();
            var security = new SecurityTeam();
            var fireDept = new FireDepartment();

            // Subscribe methods to the event
            alarm.AlarmRaised += security.OnAlarmRaised;
            alarm.AlarmRaised += fireDept.OnAlarmRaised;

            // Trigger event
            alarm.TriggerAlarm("Data Center Room 3");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Delegate target methods
        static void PrintMessage(string msg)
        {
            Console.WriteLine($"[Printer] {msg}");
        }

        static void UpperCasePrinter(string msg)
        {
            Console.WriteLine($"[UpperCasePrinter] {msg.ToUpper()}");
        }
    }
}
