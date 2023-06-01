// See https://aka.ms/new-console-template for more information
using DIP.Before.EmailSender;

Console.WriteLine("Hello, World!");


var emailNotificationService = new EmailNotificationService(EmailSenderType.Smtp);

emailNotificationService.Send("borzo.nosrati@outlook.com", "a message to sent.");


Console.ReadKey();