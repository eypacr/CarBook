using CarBook.Domain.Entities;

namespace CarBook.Application.RepositoryInterfaces;

public interface ITagCloudRepository
{
    List<TagCloud> GetTagCloudByBlogId(int id);
}
