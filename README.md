🧠 CSharpDeepDive
A structured, project-based deep dive into C# internals and .NET runtime behavior.
This repository is designed as a long-term knowledge base and learning playground for understanding how C# really works under the hood.

🔍 Topics Covered
Module	Description
01_CompilationDemo	Understand how C# code is compiled into IL (Intermediate Language) and then JIT-compiled to native machine code. Includes IL inspection using ILDASM.
02_CLRRuntimeDemo (Coming Up)	Dive into the Common Language Runtime (CLR) — stack vs. heap memory, garbage collection, and object lifecycle.
03_TypeSystemDemo (Planned)	Explore the type system, boxing/unboxing, metadata tokens, and Reflection.
04_ExecutionModelDemo (Planned)	Learn how method calls, exceptions, and the call stack work internally.
05_AdvancedConceptsDemo (Planned)	Dig into delegates, events, async/await, and continuations.
06_PerformanceDebuggingDemo (Planned)	Use unsafe code, Span<T>, memory profiling, and debug IL/runtime using tools.

🛠 Tools Used
Visual Studio (C# .NET 6/7+)

ILDASM / ILSpy (for IL inspection)

.NET CLI (for builds and optional AOT scenarios)

💡 Who Is This For?
Backend developers preparing for product-based company interviews

C#/.NET professionals wanting to build low-level understanding

Students and enthusiasts diving deep into language internals

🧩 Learning Style
Each module contains:

A runnable console demo (Program.cs)

Explanatory notes (notes.md)

Optional output like IL dumps and diagrams
