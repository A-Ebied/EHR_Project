using EHR_MVC.Models;

namespace EHR_MVC.Repositories.Contracts
{
    public interface IMLAPI
    {
        Task<string> SendAsync(string imgUrl);
    }
}
