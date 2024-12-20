using CarBook.Domain.Entities;

namespace CarBook.Application.RepositoryInterfaces;

public interface IBlogRepository
{
    public List<Blog> GetLast3BlogsWithAuthors();
    public List<Blog> GetAllBlogsWithAuthors();
}
