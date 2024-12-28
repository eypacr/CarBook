using CarBook.Application.RepositoryInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories;

public class AuthorRepository : IAuthorRepository
{
    private readonly CarBookContext _context;

    public AuthorRepository(CarBookContext context)
    {
        _context = context;
    }

    public async Task<Author> GetBlogsByAuthorAsync(int id)
    {
        return await _context.Authors
               .Include(a => a.Blogs)  // Yazarın bloglarını dahil ediyoruz
               .FirstOrDefaultAsync(a => a.AuthorId == id);
    }
}
