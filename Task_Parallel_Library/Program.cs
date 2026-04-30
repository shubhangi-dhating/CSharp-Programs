using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Create and run tasks
        Task t1 = Task.Run(() =>
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Task 1: " + i);
            }
        });

        Task t2 = Task.Run(() =>
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Task 2: " + i);
            }
        });

        // Wait for both tasks to complete
        Task.WaitAll(t1, t2);

        Console.WriteLine("All Tasks Completed.");

        Console.ReadLine();
    }
}
