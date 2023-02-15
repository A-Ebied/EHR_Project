using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EHR_API.Entities.Models;

namespace EHR_API.Entities.ModelsConfiguration
{
    public class GovernorateConfiguration : IEntityTypeConfiguration<Governorate>
    {
        public void Configure(EntityTypeBuilder<Governorate> builder)
        {
            builder.HasData(
                new Governorate { Id = 1, Title = "الشرقية" }, 
                new Governorate { Id = 2, Title = "شمال سيناء" }, 
                new Governorate { Id = 3, Title = "القاهرة" }, 
                new Governorate { Id = 4, Title = "المنيا" }, 
                new Governorate { Id = 5, Title = "الدقهلية" }, 
                new Governorate { Id = 6, Title = "الإسكندرية" }, 
                new Governorate { Id = 7, Title = "الإسماعيلية" }
                );
        }
    }
}
