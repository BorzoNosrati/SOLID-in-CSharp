
using DIP.After.Abstraction;
using System;
namespace EmailUtility;

public class CustomImapClient:IEmailSenderClient
{
    public bool Send(string emailAddress, string message)
    {
        Console.WriteLine($"Imap: Email sent to {emailAddress}, the message was: {message}");
        return true;
    }
}