using CarBook.Application.RepositoryInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;

namespace CarBook.Persistence.Repositories;

public class TagCloudRepository : ITagCloudRepository
{
    private readonly CarBookContext _context;

    public TagCloudRepository(CarBookContext context)
    {
        _context = context;
    }

    public List<TagCloud> GetTagCloudByBlogId(int id) => _context.TagClouds.Where(x => x.BlogId == id).ToList();

}
