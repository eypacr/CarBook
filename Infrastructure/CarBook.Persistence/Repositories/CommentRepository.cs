using CarBook.Application.RepositoryInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories;

public class CommentRepository : Repository<Comment>,ICommentRepository
{
    public CommentRepository(CarBookContext context) : base(context)
    {
    }
    public async Task<Comment> GetByCommentIdAsync(int id)
    {
        return await _context.Comments
            .Include(x => x.Blog)
            .ThenInclude(x => x.Author)
            .FirstOrDefaultAsync(x => x.CommentId == id);
    }
    public List<Comment> GetCommentListByBlogId(int id)
    {
        var values = _context.Comments.Where(x => x.BlogId == id).Include(x => x.Blog).ThenInclude(x => x.Author).ToList();
        return values;
    }
    public List<Comment> GetCommentListWithAllInfo()
    {
        var values = _context.Comments.Include(x => x.Blog).ThenInclude(x => x.Author).ToList();
        return values;
    }
}
