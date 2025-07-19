# 🧠 C# Compilation Flow

## Step-by-step:
1. C# source → CIL (IL code) → Machine code via JIT.
2. JIT only compiles methods when first called.
3. Tools to inspect IL:
   - `ILDASM` (Visual Studio Developer Command Prompt)
   - `ILSpy`

## Demo Summary:
- This project defines a simple `Add` method.
- When run, the CLR JIT compiles `Add()` to native code at runtime.