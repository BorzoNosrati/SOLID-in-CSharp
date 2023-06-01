

namespace EmailUtility;
public class EmailNotification
{
    private readonly IEmailSenderClient _sender;

    public EmailNotification(IEmailSenderClient sender)
    {
        _sender = sender;
    }

    public void Send(string emailAddress, string message)
    {
        _sender.Send(emailAddress, message);

    }
}
