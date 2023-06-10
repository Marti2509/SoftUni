using ForumApp.Core.Models.Post;

namespace ForumApp.Core.Contracts
{
    public interface IPostService
    {
        Task<List<PostViewModel>> GetPostAsync();
    }
}
