using System;

class Demo
{
    public int value;

    public Demo(int v)
    {
        value = v;
    }

    ~Demo() // Destructor (called by Garbage Collector)
    {
        Console.WriteLine("Object with value " + value + " is destroyed");
    }
}

class Program
{
    static void Main()
    {
        // Stack allocation (value type)
        int a = 10;

        // Heap allocation (reference type)
        Demo obj1 = new Demo(1);
        Demo obj2 = new Demo(2);

        Console.WriteLine("Objects created");

        // Making objects eligible for garbage collection
        obj1 = null;
        obj2 = null;

        // Forcing Garbage Collection
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Garbage Collection completed");
    }
}
