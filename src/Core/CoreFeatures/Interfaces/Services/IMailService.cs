using Core.CoreFeatures.Security.Requests.Mail;

namespace Core.CoreFeatures.Interfaces.Services;

public interface IMailService
{
    Task SendAsync(MailRequest request);
}