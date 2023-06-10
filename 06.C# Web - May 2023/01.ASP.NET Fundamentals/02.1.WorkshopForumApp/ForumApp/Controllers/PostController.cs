using Microsoft.AspNetCore.Mvc;

using ForumApp.Data;
using ForumApp.Core.Contracts;

namespace ForumApp.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService postService;

        public PostController(IPostService _postService)
        {
            postService = _postService;
        }

        public async Task<IActionResult> All()
        {
            var models = await postService.GetPostAsync();

            return View(models);
        }
    }
}
