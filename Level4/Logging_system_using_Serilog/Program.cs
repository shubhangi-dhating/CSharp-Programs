// Logging System using Serilog in C#
// Install Package:
// Serilog
// Serilog.Sinks.Console
// Serilog.Sinks.File

using System;
using Serilog;

namespace SerilogDemo
{
    class Program
    {
        static void Main()
        {
            // Configure Logger
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console()
                .WriteTo.File(
                    "logs/app-log-.txt",
                    rollingInterval: RollingInterval.Day)
                .CreateLogger();

            try
            {
                Log.Information("Application Started");

                Console.Write("Enter First Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Second Number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Log.Information("User entered numbers {Num1} and {Num2}", num1, num2);

                int result = num1 / num2;

                Console.WriteLine("Result = " + result);

                Log.Information("Division Result = {Result}", result);
            }
            catch (DivideByZeroException ex)
            {
                Log.Error(ex, "Attempted division by zero");
                Console.WriteLine("Error: Cannot divide by zero");
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Unexpected Error Occurred");
                Console.WriteLine("System Error");
            }
            finally
            {
                Log.Information("Application Closed");
                Log.CloseAndFlush();
            }
        }
    }
}

