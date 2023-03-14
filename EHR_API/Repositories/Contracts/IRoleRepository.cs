using EHR_API.Entities.DTOs.UserDataDTOs.RolesDTOs;
using EHR_API.Entities.Models;
using Microsoft.AspNetCore.Identity;

namespace EHR_API.Repositories.Contracts
{
    public interface IRoleRepository
    {
        Task<List<IdentityRole>> GetRolesAsync();
        Task<string> GetRoleAsync(string roleName);
    }
}
