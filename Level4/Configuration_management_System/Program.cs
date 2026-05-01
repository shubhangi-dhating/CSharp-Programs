// Configuration Management using appsettings.json in C# Console App

// Install Packages:
// Microsoft.Extensions.Configuration
// Microsoft.Extensions.Configuration.Json
// Microsoft.Extensions.Configuration.Binder

using System;
using Microsoft.Extensions.Configuration;

namespace ConfigDemo
{
    class Program
    {
        static void Main()
        {
            // Read appsettings.json
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Read Values
            string appName = config["AppSettings:ApplicationName"];
            string version = config["AppSettings:Version"];
            string dbConn = config["ConnectionStrings:DefaultConnection"];

            Console.WriteLine("Application Name : " + appName);
            Console.WriteLine("Version          : " + version);
            Console.WriteLine("Connection String: " + dbConn);
        }
    }
}

