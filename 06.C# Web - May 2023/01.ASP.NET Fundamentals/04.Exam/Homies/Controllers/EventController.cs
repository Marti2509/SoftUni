using Homies.Contracts;
using Homies.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homies.Controllers
{
    public class EventController : BaseController
    {
        private readonly IEventService service;

        public EventController(IEventService _service)
        {
            service = _service;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var models = await service.GetAllEventsAsync();

            return View(models);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var types = await service.GetEventTypesAsync();

            var model = new AddEditViewModel()
            {
                Types = types
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await service.AddAsync(model, GetUserId());

            return RedirectToAction("All", "Event");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await service.FindEventByIdAsync(id);
            
            if (GetUserId() != model.CreatorId)
            {
                return RedirectToAction("All", "Event");
            }

            var types = await service.GetEventTypesAsync();
            
            model.Types = types;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AddEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await service.EditAsync(model);

            return RedirectToAction("All", "Event");
        }

        [HttpGet]
        public async Task<IActionResult> Joined()
        {
            var models = await service.GetMyJoinedEventsAsync(GetUserId());

            return View(models);
        }

        [HttpPost]
        public async Task<IActionResult> Join(int id)
        {
            var @event = await service.FindEventForJoinLeaveByIdAsync(id);

            bool result = await service.JoinEventAsync(GetUserId(), @event);

            if (result)
            {
                return RedirectToAction("Joined", "Event");
            }

            return RedirectToAction("All", "Event");
        }

        [HttpPost]
        public async Task<IActionResult> Leave(int id)
        {
            var @event = await service.FindEventForJoinLeaveByIdAsync(id);

            await service.LeaveEventAsync(GetUserId(), @event);

            return RedirectToAction("All", "Event");
        }

        public async Task<IActionResult> Details(int id)
        {
            var @event = await service.GetDetailsAsync(id);

            return View(@event);
        }
    }
}
