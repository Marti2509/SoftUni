using Homies.Models;

namespace Homies.Contracts
{
    public interface IEventService
    {
        Task<List<AllEventsViewModel>> GetAllEventsAsync();

        Task AddAsync(AddEditViewModel model, string userId);

        Task<List<TypeViewModel>> GetEventTypesAsync();

        Task EditAsync(AddEditViewModel model);

        Task<AddEditViewModel> FindEventByIdAsync(int id);

        Task<AllEventsViewModel> FindEventForJoinLeaveByIdAsync(int id);

        Task<List<AllEventsViewModel>> GetMyJoinedEventsAsync(string id);

        Task<bool> JoinEventAsync(string id, AllEventsViewModel model);

        Task LeaveEventAsync(string id, AllEventsViewModel model);

        Task<DetailsViewModel> GetDetailsAsync(int id);
    }
}
