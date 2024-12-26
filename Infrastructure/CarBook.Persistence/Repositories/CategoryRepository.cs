using CarBook.Application.RepositoryInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly CarBookContext _context;

    public CategoryRepository(CarBookContext context)
    {
        _context = context;
    }

    public List<Category> GetCategoryListWithBlogCount()
    {
        var values = _context.Categories.Include(x => x.Blogs).ToList();
        return values;
    }
}
