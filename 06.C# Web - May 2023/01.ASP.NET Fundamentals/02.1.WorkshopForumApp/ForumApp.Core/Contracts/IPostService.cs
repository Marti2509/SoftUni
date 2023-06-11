using ForumApp.Core.Models.Post;

namespace ForumApp.Core.Contracts
{
    public interface IPostService
    {
        Task<List<PostViewModel>> GetPostAsync();

        Task<PostFormModel> GetPostAsync(int id);

        Task PostPostAsync(PostFormModel model);

        Task EditPostAsync(int id, PostFormModel model);

        Task DeletePostAsync(int id);
    }
}
