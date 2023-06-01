using DIP.After.Abstraction;
using DIP.After.Abstraction.Services;

namespace DIP.After.Services;

public class EmailNotificationService : IEmailNotificationService
{

    private readonly IEmailSenderClient _sender;

    public EmailNotificationService(IEmailSenderClient sender)
    {
        _sender = sender;
    }

    public void Send(string emailAddress, string message)
    {
        _sender.Send(emailAddress, message);

    }
}
