using BlazorHero.CleanArchitecture.Application.Requests.Mail;
using System.Threading.Tasks;

namespace WebApi.Core.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}