using EHR_API.Entities.DTOs;

namespace EHR_API.Extensions.DataStore
{
    public static class GovernorateStore
    {
        public static List<GovernorateDTO> governorateList = new()
        {
                new GovernorateDTO { Id=1, Title="القاهرة"},
                new GovernorateDTO { Id=2, Title="شمال سيناء"},
        };
    }
}
