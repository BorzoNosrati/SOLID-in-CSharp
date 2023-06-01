

namespace EmailUtility;
public class EmailNotification
{

    private readonly CustomSmtpClient _smtpClient;
    private readonly CustomImapClient _imapClient;
    private readonly EmailSenderType _senderType;

    public EmailNotification(EmailSenderType senderType)
    {
        _senderType = senderType;
        _smtpClient = new CustomSmtpClient();
        _imapClient = new CustomImapClient();
    }

    public void Send(string emailAddress, string message)
    {
        switch (_senderType)
        {
            case EmailSenderType.Smtp:
                _smtpClient.Send(emailAddress, message);
                break;
            case EmailSenderType.Imap:
                _imapClient.Send(emailAddress, message);
                break;
            default:
        }
    }
}
