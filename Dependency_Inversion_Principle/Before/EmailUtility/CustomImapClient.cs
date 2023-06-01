

namespace EmailUtility;

public class CustomImapClient
{
    public bool Send(string emailAddress, string message)
    {
        Console.WriteLine($"Imap: Email sent to {emailAddress}, the message was {message}");
    }
}