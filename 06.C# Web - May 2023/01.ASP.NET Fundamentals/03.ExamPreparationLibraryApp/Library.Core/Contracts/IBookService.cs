using Library.Core.Models;

namespace Library.Core.Contracts
{
    public interface IBookService
    {
        Task<List<AllBookViewModel>> GetAllBooksAsync();
        
        Task<List<MyBookViewModel>> GetMyBooksAsync(string id);

        Task AddBookAsync(AddBookFormModel model);

        Task<AddBookFormModel> GetNewBookFormModelAsync();

        Task<BookViewModel> GetBookByIdAsync(int id);

        Task AddToCollectionAsync(string id, BookViewModel book);

        Task RemoveFromCollectionAsync(string id, BookViewModel book);
    }
}
