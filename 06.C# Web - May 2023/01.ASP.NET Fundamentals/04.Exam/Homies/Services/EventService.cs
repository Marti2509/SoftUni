using Homies.Contracts;
using Homies.Data;
using Homies.Data.Models;
using Homies.Models;
using Microsoft.EntityFrameworkCore;

namespace Homies.Services
{
    public class EventService : IEventService
    {
        private readonly HomiesDbContext context;

        public EventService(HomiesDbContext _context)
        {
            context = _context;
        }

        public async Task<List<AllEventsViewModel>> GetAllEventsAsync()
        {
            return await context.Events
                .Select(e => new AllEventsViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Start = e.Start.ToString("yyyy-MM-dd H:mm"),
                    Organiser = e.Organiser.UserName,
                    Type = e.Type.Name
                })
                .ToListAsync();
        }

        public async Task AddAsync(AddEditViewModel model, string userId)
        {
            var @event = new Event()
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                Start = DateTime.Parse(model.Start),
                End = DateTime.Parse(model.End),
                CreatedOn = DateTime.UtcNow,
                OrganiserId = userId,
                TypeId = model.TypeId
            };

            context.Events.Add(@event);
            await context.SaveChangesAsync();
        }

        public async Task<List<TypeViewModel>> GetEventTypesAsync()
        {
            return await context.Types
                .Select(t => new TypeViewModel
                {
                    Id = t.Id,
                    Name = t.Name
                })
                .ToListAsync();
        }

        public async Task EditAsync(AddEditViewModel model)
        {
            var @event = await context.Events
                .FindAsync(model.Id);

            if (@event != null)
            {
                @event.Name = model.Name;
                @event.Description = model.Description;
                @event.Start = DateTime.Parse(model.Start);
                @event.End = DateTime.Parse(model.End);
                @event.TypeId = model.TypeId;
            }

            await context.SaveChangesAsync();
        }

        public async Task<AddEditViewModel?> FindEventByIdAsync(int id)
        {
            return await context.Events
                .Where(k => k.Id == id)
                .Select(e => new AddEditViewModel()
                {
                    Id = e.Id,
                    Name = e.Name,
                    Description = e.Description,
                    Start = e.Start.ToString(),
                    End = e.End.ToString(),
                    TypeId = e.TypeId,
                    CreatorId = e.OrganiserId
                })
                .FirstOrDefaultAsync();
        }

        public async Task<List<AllEventsViewModel>> GetMyJoinedEventsAsync(string id)
        {
            return await context.EventsParticipants
                .Where(e => e.HelperId == id)
                .Select(e => new AllEventsViewModel()
                {
                    Id = e.Event.Id,
                    Name = e.Event.Name,
                    Start = e.Event.Start.ToString("yyyy-MM-dd H:mm"),
                    Type = e.Event.Type.Name,
                    Organiser = e.Event.Organiser.UserName
                })
                .ToListAsync();
        }

        public async Task<bool> JoinEventAsync(string id, AllEventsViewModel model)
        {
            bool joined = await context.EventsParticipants
                    .AnyAsync(e => e.HelperId == id && e.EventId == model.Id);

            if (!joined)
            {
                var eventParticipant = new EventParticipant()
                {
                    HelperId = id,
                    EventId = model.Id,
                };

                await context.EventsParticipants.AddAsync(eventParticipant);
                await context.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<AllEventsViewModel?> FindEventForJoinLeaveByIdAsync(int id)
        {
            return await context.Events
                .Where(k => k.Id == id)
                .Select(e => new AllEventsViewModel()
                {
                    Id = e.Id,
                    Name = e.Name,
                    Start = e.Start.ToString(),
                    Type = e.Type.Name,
                    Organiser = e.Organiser.UserName
                })
                .FirstOrDefaultAsync();
        }

        public async Task LeaveEventAsync(string id, AllEventsViewModel model)
        {
            bool joined = await context.EventsParticipants
                    .AnyAsync(e => e.HelperId == id && e.EventId == model.Id);

            if (joined)
            {
                var eventParticipant = await context.EventsParticipants
                    .Where(u => u.HelperId == id && u.EventId == model.Id)
                    .FirstAsync();

                context.EventsParticipants.Remove(eventParticipant);
                await context.SaveChangesAsync();
            }
        }

        public async Task<DetailsViewModel?> GetDetailsAsync(int id)
        {
            return await context.Events
                .Where(e => e.Id == id)
                .Select(e => new DetailsViewModel()
                {
                    Id = e.Id,
                    Name = e.Name,
                    Description = e.Description,
                    Type = e.Type.Name,
                    Start = e.Start.ToString("yyyy-MM-dd H:mm"),
                    End = e.End.ToString("yyyy-MM-dd H:mm"),
                    CreatedOn = e.CreatedOn.ToString("yyyy-MM-dd H:mm"),
                    Organiser = e.Organiser.Email
                })
                .FirstOrDefaultAsync();
        }
    }
}
