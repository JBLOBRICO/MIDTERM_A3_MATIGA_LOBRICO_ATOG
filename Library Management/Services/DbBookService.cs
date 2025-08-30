using Library_Management.Data;
using Library_Management.Models;

public class DbBookService : IBookService
{

    private readonly BookDbContext _BookDbContext;

    public DbBookService(BookDbContext bookDbContext)
    {
        _BookDbContext = bookDbContext;
    }


    public void AddBook(AddBookViewModel book)
    {
        throw new NotImplementedException();
    }

    public void DeleteBook(Guid id)
    {
        throw new NotImplementedException();
    }

    public EditBookViewModel GetBookById(Guid id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<BookListViewModel> GetBooks()
    {
        return _BookDbContext.BookLists.Select(b => new BookListViewModel
        {
            BookId = b.BookId,
            Title = b.Title,
            Genre = b.Genre,
            PublishedDate = b.PublishedDate
        }).ToList();
    }

    public void UpdateBook(EditBookViewModel vm)
    {
        throw new NotImplementedException();
    }
}
