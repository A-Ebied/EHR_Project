using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class BadHabitRepository : RepositoryBase<BadHabit>, IBadHabitRepository
    {
        public BadHabitRepository(ApplicationDbContext db) : base(db) { }
    }
}
