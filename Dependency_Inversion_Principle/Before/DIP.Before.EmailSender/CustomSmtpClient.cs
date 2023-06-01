

namespace DIP.Before.EmailSender;

public class CustomSmtpClient
{
    public bool Send(string emailAddress, string message)
    {
        Console.WriteLine($"Smtp: Email sent to {emailAddress}, the message was: {message}");
        return true;
    }
}
