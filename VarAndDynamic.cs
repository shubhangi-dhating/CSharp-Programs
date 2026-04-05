using System;

class VarAndDynamic
{
    static void Main()
    {
        // ── VAR ──────────────────────────────────────
        var num = 10;
        var name = "Rahul";
        var price = 99.99;
        var flag = true;

        Console.WriteLine("── VAR ──");
        Console.WriteLine($"num   = {num}");
        Console.WriteLine($"name  = {name}");
        Console.WriteLine($"price = {price}");
        Console.WriteLine($"flag  = {flag}");

        // ── DYNAMIC ──────────────────────────────────
        dynamic d = 10;
        Console.WriteLine("\n── DYNAMIC ──");
        Console.WriteLine($"d = {d}  (int)");

        d = "Hello";
        Console.WriteLine($"d = {d}  (string)");

        d = 3.14;
        Console.WriteLine($"d = {d}  (double)");

        d = true;
        Console.WriteLine($"d = {d}  (bool)");
    }
}
