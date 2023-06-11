using Microsoft.EntityFrameworkCore;

using ForumApp.Data;
using ForumApp.Core.Contracts;
using ForumApp.Core.Models.Post;
using ForumApp.Data.Models;

namespace ForumApp.Core.Services
{
    public class PostService : IPostService
    {
        private readonly ForumAppDbContext dbContext;

        public PostService(ForumAppDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task DeletePostAsync(int id)
        {
            var post = await dbContext.Posts.FindAsync(id);

            dbContext.Remove(post);
            await dbContext.SaveChangesAsync();
        }

        public async Task EditPostAsync(int id, PostFormModel model)
        {
            var post = await dbContext.Posts.FindAsync(id);

            post.Title = model.Title;
            post.Content = model.Content;

            await dbContext.SaveChangesAsync();
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

        public async Task<PostFormModel> GetPostAsync(int id)
        {
            var post = await dbContext.Posts.FindAsync(id);

            return new PostFormModel()
            {
                Title = post.Title,
                Content = post.Content
            };
        }

        public async Task PostPostAsync(PostFormModel model)
        {
            var post = new Post()
            {
                Title = model.Title,
                Content = model.Content
            };

            await dbContext.Posts.AddAsync(post);
            await dbContext.SaveChangesAsync();
        }
    }
}
