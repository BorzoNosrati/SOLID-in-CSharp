using DIP.After.Abstraction;
using EmailUtility;

namespace DIP.After.EmailFactory;
public class EmailRepository
{
     public static IEmailSenderClient CreateSmtpClient(){
        return new CustomSmtpClient();
     }
     public static IEmailSenderClient CreateImapClient(){
        return new CustomImapClient();
     }
}
