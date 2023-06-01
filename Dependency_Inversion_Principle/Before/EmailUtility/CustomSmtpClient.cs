

namespace EmailUtility;

public class CustomSmtpClient
{
    public bool Send(string emailAddress, string message)
    {
        Console.WriteLine($"Smtp: Email sent to {emailAddress}, the message was {message}");
    }
}
