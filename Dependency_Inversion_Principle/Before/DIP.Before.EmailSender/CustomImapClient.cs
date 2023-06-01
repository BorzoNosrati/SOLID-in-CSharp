
using System;
namespace DIP.Before.EmailSender;

public class CustomImapClient
{
    public bool Send(string emailAddress, string message)
    {
        Console.WriteLine($"Imap: Email sent to {emailAddress}, the message was: {message}");
        return true;
    }
}