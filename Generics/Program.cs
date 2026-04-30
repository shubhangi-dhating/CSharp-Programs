using System;

// Generic class
class Demo<T>
{
    public T value;

    public void Show(T data)
    {
        value = data;
        Console.WriteLine("Value = " + value);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Integer type
        Demo<int> d1 = new Demo<int>();
        d1.Show(100);

        // String type
        Demo<string> d2 = new Demo<string>();
        d2.Show("Rahul");

        Console.ReadLine();
    }
}

