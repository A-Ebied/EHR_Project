using EHR_API.Entities;
using EHR_API.Entities.DTOs.UserDataDTOs.UserRolesDTOs;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EHR_API.Repositories.Implementation
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _db;
        public RoleRepository(ApplicationDbContext db) 
        {
           _db= db;
        }

        public async Task<List<IdentityRole>> GetRolesAsync()
        {
            var roleStore = new RoleStore<IdentityRole>(_db);
            return await roleStore.Roles.ToListAsync();
        }
 
    }
}
