using Shared.DTO.Requests.Mail;

namespace Core.CoreFeatures.Interfaces.Services;

public interface IMailService
{
    Task SendAsync(MailRequest request);
}