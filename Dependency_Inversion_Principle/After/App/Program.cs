// See https://aka.ms/new-console-template for more information
using DIP.After.EmailFactory;

Console.WriteLine("Hello, World!");




var emailNotification=new EmailUtility.EmailNotification(EmailRepository.CreateSmtpClient());

emailNotification.Send("borzo.nosrati@outlook.com","a message to sent.");


 

