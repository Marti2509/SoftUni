using ChatApp.Models.Message;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace ChatApp.Controllers
{
    public class ChatController : Controller
    {
        private static ICollection<KeyValuePair<string, string>> _messages = new List<KeyValuePair<string, string>>();

        [HttpGet]
        public IActionResult Show()
        {
            if (_messages.Count == 0)
            {
                return View(new ChatViewModel());
            }

            ChatViewModel chatModel = new ChatViewModel()
            {
                Messages = _messages.Select(m => new MessageViewModel()
                {
                    Sender = m.Key,
                    Message = m.Value
                })
                .ToList()
            };

            return View(chatModel);
        }

        [HttpPost]
        public IActionResult Send(ChatViewModel chat)
        {
            var newMessage = chat.CurrentMessage;

            _messages.Add(new KeyValuePair<string, string>(newMessage.Sender, newMessage.Message));

            return RedirectToAction("Show");
        }
    }
}
