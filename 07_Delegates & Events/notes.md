# ⚙️ Delegates & Events in C#

A hands-on demo project that explains how **Delegates** and **Events** work in C# using a simple, real-world example — an **Alarm System** that notifies multiple subscribers (Security Team, Fire Department) when an alarm is triggered.

---

## 🚀 Features

- ✅ Demonstrates **basic delegates** and **multicast delegates**
- ✅ Implements **events** using both `Action` and the standard `EventHandler` pattern
- ✅ Shows **publish/subscribe** communication between classes
- ✅ Includes **custom `EventArgs`** to pass event data
- ✅ Clean and easy to extend for interview demos

---

## 🧠 Concepts Covered

| Concept | Description |
|----------|--------------|
| **Delegate** | A type-safe function pointer in C#. |
| **Multicast Delegate** | A delegate that can point to multiple methods. |
| **Event** | A wrapper around a delegate that enforces encapsulation and allows controlled subscriptions. |
| **EventHandler / EventArgs** | Standard .NET pattern for event handling with extra data. |
| **Publish/Subscribe** | Loose coupling between sender (publisher) and receiver (subscriber). |

---

## 📂 Project Structure

DelegatesAndEventsDemo/
│
├── Program.cs
├── AlarmSystem.cs
├── AlarmEventArgs.cs
├── SecurityTeam.cs
├── FireDepartment.cs
└── README.md



## 💻 Example Output

=== Delegates & Events Demo ===
[Printer] Hello from a basic delegate!
[Printer] This will be printed twice!
[UpperCasePrinter] THIS WILL BE PRINTED TWICE!

🚨 Alarm Triggered!
👮 Security Team notified! Location: Data Center Room 3 at 10:00:01 AM
🔥 Fire Dept dispatched to Data Center Room 3 at 10:00:01 AM



## ⚡ How to Run

1. Open the project in **Visual Studio** or **VS Code**.  
2. Build and run:
   ```bash
   dotnet run
Observe how multiple subscribers react to the same event trigger.

🧩 Real-World Analogy
Delegate → “Who should I call?” (a function reference)

Event → “When this happens, call all subscribers” (notify pattern)

Publisher → Alarm system raising an event

Subscribers → Teams responding to the event

📘 Learning Resources
Microsoft Docs: Delegates

Microsoft Docs: Events

YouTube:

IAmTimCorey – Delegates and Events Explained

Nick Chapsas – Events in C#

🏁 Key Takeaways
Delegates act as method references; events are safe delegate wrappers.

Use Action, Func, and EventHandler<T> to simplify event-driven patterns.

This model is used widely in UI frameworks, real-time systems, and microservices messaging.