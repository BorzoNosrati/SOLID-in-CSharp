﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




var emailNotification=new EmailUtility.EmailNotification(EmailUtility.EmailSenderType.Smtp);

emailNotification.Send("borzo.nosrati@outlook.com","a message to sent.");


 

