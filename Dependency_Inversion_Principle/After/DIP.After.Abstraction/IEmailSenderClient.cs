namespace DIP.After.Abstraction;

public interface IEmailSenderClient
{
    bool Send(string emailAddress, string message);
}
