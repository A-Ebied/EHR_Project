using EHR_API.Entities;

namespace EHR_API.Repositories.Contracts
{
    public interface IEmailSender
    {
        Task SendEmailAsync(Message message);
    }
}
