// Question: Program to demonstrate interfaces
// Generated: 2026-03-06

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

public class Program108
{
    public static async Task Main()
    {
        ILogger logger = new ConsoleLogger();
        logger.Log("Hello via interface");
    }

    private sealed class DemoReadonly
    {
        public readonly int Value;
        public DemoReadonly(int value) { Value = value; }
    }

    private enum Day { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

    private readonly struct Point
    {
        public int X { get; }
        public int Y { get; }
        public Point(int x, int y) { X = x; Y = y; }
        public override string ToString() => $"({X},{Y})";
    }

    private static class MathUtil { public static int Square(int x) => x * x; }

    private sealed class NameList
    {
        private readonly string[] _items = new string[10];
        public string this[int index]
        {
            get => _items[index] ?? string.Empty;
            set => _items[index] = value;
        }
    }

    private sealed class RefPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    private sealed class Person { public string Name { get; set; } = string.Empty; public int Age { get; set; } }

    private sealed class Counter
    {
        public int Value { get; private set; }
        public Counter(int start) { Value = start; }
        public void Increment() => Value++;
    }

    private sealed class Temp
    {
        private readonly string _name;
        public Temp(string name) { _name = name; }
        ~Temp() { Console.WriteLine($"Finalizer called for {_name}"); }
    }

    private abstract class Animal { public virtual void Speak() => Console.WriteLine("Animal speaks"); }
    private sealed class Dog : Animal { public override void Speak() => Console.WriteLine("Dog barks"); }
    private sealed class Cat : Animal { public override void Speak() => Console.WriteLine("Cat meows"); }

    private abstract class Shape { public abstract double Area(); }
    private sealed class Circle : Shape
    {
        private readonly double _r;
        public Circle(double r) { _r = r; }
        public override double Area() => Math.PI * _r * _r;
    }

    private interface ILogger { void Log(string message); }
    private sealed class ConsoleLogger : ILogger { public void Log(string message) => Console.WriteLine($"[LOG] {message}"); }

    private sealed class BankAccount
    {
        public decimal Balance { get; private set; }
        public BankAccount(decimal opening) { Balance = opening; }
        public void Deposit(decimal amount) { if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount)); Balance += amount; }
        public void Withdraw(decimal amount) { if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount)); if (amount > Balance) throw new InvalidOperationException("Insufficient"); Balance -= amount; }
    }

    private sealed class AccessDemo
    {
        private void PrivateMethod() => Console.WriteLine("private");
        protected void ProtectedMethod() => Console.WriteLine("protected");
        internal void InternalMethod() => Console.WriteLine("internal");
        public void PublicMethod() { Console.WriteLine("public"); PrivateMethod(); ProtectedMethod(); InternalMethod(); }
    }

    private sealed class ReadonlyDemo { public readonly int Value; public ReadonlyDemo(int v) { Value = v; } }

    private static class Util { public static int Add(int a, int b) => a + b; }

    private sealed class SealedDemo { public void Hello() => Console.WriteLine("I am sealed"); }

    private partial class PartialPerson { public string FirstName { get; set; } = string.Empty; }
    private partial class PartialPerson { public string LastName { get; set; } = string.Empty; public string FullName() => FirstName + " " + LastName; }

    private class Base { public virtual void Show() => Console.WriteLine("Base"); }
    private class Derived : Base { public override void Show() => Console.WriteLine("Derived"); }

    private interface IClock { DateTime Now { get; } }
    private sealed class SystemClock : IClock { public DateTime Now => DateTime.Now; }
    private sealed class GreetingService
    {
        private readonly IClock _clock;
        public GreetingService(IClock clock) { _clock = clock; }
        public string Greet(string name) => $"Hello {name} @ {_clock.Now:HH:mm:ss}";
    }

    private sealed class MyAppException : Exception { public MyAppException(string msg) : base(msg) { } }

    private sealed class Alarm
    {
        public event EventHandler<string>? Raised;
        public void Trigger(string message) => Raised?.Invoke(this, message);
    }

    private static class StringExtensions
    {
        public static string ToTitleCase(this string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return s;
            return char.ToUpperInvariant(s[0]) + s[1..];
        }
    }

    private sealed class Box<T> where T : struct { public T Value { get; } public Box(T value) { Value = value; } }

    private sealed class Repo
    {
        private readonly List<Item> _items = new();
        private int _nextId = 1;
        public Item Create(string name) { var it = new Item { Id = _nextId++, Name = name }; _items.Add(it); return it; }
        public IReadOnlyList<Item> ReadAll() => _items;
        public bool Update(int id, string name) { var it = _items.FirstOrDefault(x => x.Id == id); if (it is null) return false; it.Name = name; return true; }
        public bool Delete(int id) { var it = _items.FirstOrDefault(x => x.Id == id); if (it is null) return false; _items.Remove(it); return true; }
        public sealed class Item { public int Id { get; set; } public string Name { get; set; } = string.Empty; }
    }

    private sealed class Bus
    {
        public event EventHandler<string>? Message;
        public void Publish(string msg) => Message?.Invoke(this, msg);
    }
}
