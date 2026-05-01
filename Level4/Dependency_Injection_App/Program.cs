// Dependency Injection in C# Console App

// Install Package:
// Microsoft.Extensions.DependencyInjection

using System;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDI
{
    // Service Interface
    public interface IMessageService
    {
        void SendMessage(string message);
    }

    // Service Implementation
    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Email Sent: " + message);
        }
    }

    // Business Class
    public class NotificationManager
    {
        private readonly IMessageService _messageService;

        // Constructor Injection
        public NotificationManager(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Notify()
        {
            _messageService.SendMessage("Welcome to Dependency Injection");
        }
    }

    class Program
    {
        static void Main()
        {
            // Configure DI Container
            ServiceCollection services = new ServiceCollection();

            services.AddTransient<IMessageService, EmailService>();
            services.AddTransient<NotificationManager>();

            ServiceProvider provider = services.BuildServiceProvider();

            // Resolve Service
            var manager = provider.GetService<NotificationManager>();

            manager.Notify();
        }
    }
}
