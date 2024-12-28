using CarBook.Domain.Entities;

namespace CarBook.Application.RepositoryInterfaces;

public interface IAuthorRepository
{
    Task<Author> GetBlogsByAuthorAsync(int id);
}
