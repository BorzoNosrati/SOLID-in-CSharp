namespace EmailUtility;

public interface IEmailSenderClient
{
    bool Send(string emailAddress, string message);
}
