

using DIP.After.EmailFactory;
using DIP.After.Services;

var sender = EmailRepository.CreateSmtpClient();
var emailNotification = new EmailNotificationService(sender);

emailNotification.Send("borzo.nosrati@outlook.com", "a message to sent.");




Console.ReadKey();