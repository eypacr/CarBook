using CarBook.Domain.Entities;

namespace CarBook.Application.RepositoryInterfaces;

public interface ICommentRepository:IRepository<Comment>
{
    List<Comment> GetCommentListByBlogId(int id);
    List<Comment> GetCommentListWithAllInfo();
    Task<Comment> GetByCommentIdAsync(int id);
}
