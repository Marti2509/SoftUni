using Microsoft.EntityFrameworkCore;

using ForumApp.Data;
using ForumApp.Core.Contracts;
using ForumApp.Core.Models.Post;

namespace ForumApp.Core.Services
{
    public class PostService : IPostService
    {
        private readonly ForumAppDbContext dbContext;

        public PostService(ForumAppDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<List<PostViewModel>> GetPostAsync()
        {
            return await dbContext.Posts
                .Select(p => new PostViewModel
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content = p.Content
                })
                .ToListAsync();
        }
    }
}
