using EmailUtility;

namespace DIP.After.EmailFactory;
public class EmailRepository
{
     public static CustomSmtpClient CreateSmtpClient(){
        return new CustomSmtpClient();
     }
     public static CustomImapClient CreateImapClient(){
        return new CustomImapClient();
     }
}
