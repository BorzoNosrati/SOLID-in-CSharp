

using DIP.After.EmailFactory;
using DIP.After.Services;

var sender = EmailRepository.CreateSmtpClient();
var emailNotificationService = new EmailNotificationService(sender);

emailNotificationService.Send("borzo.nosrati@outlook.com", "a message to sent.");




Console.ReadKey();