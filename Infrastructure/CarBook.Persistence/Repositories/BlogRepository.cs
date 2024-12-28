using CarBook.Application.RepositoryInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly CarBookContext _context;

        public BlogRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<Blog> GetAllBlogsWithAuthors()
        {
            var values = _context.Blogs.Include(b => b.Author).Include(a => a.Category).ToList();
            return values;
        }

        public async Task<List<Blog>> GetBlogsByCategoryAsync(int categoryId)
        {
            return await _context.Blogs
                .Where(b => b.CategoryId == categoryId)
                .Include(b => b.Author) 
                .Include(b => b.TagClouds) 
                .Include(b => b.Comments) 
                .Include(b => b.Category)
                .ToListAsync();
        }

        public async Task<List<Blog>> GetBlogWithAllInfoById(int id)
        {
            return await _context.Blogs
                .Where(x => x.BlogId == id)
                .Include(x => x.Category)
                .Include(x => x.Author)
                .ToListAsync();
        }



        public List<Blog> GetLast3BlogsWithAuthors()
        {
            var values = _context.Blogs.Include(x => x.Author).OrderByDescending(x => x.BlogId).Take(3).ToList();
            return values;
        }
    }
}
