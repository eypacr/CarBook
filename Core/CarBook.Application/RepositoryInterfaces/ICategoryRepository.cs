using CarBook.Domain.Entities;

namespace CarBook.Application.RepositoryInterfaces;

public interface ICategoryRepository
{
    public List<Category> GetCategoryListWithBlogCount();
}
