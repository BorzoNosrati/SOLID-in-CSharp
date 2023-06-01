namespace DIP.After.Abstraction.Services
{
    public interface IEmailNotificationService
    {
        void Send(string emailAddress, string message);
    }
}