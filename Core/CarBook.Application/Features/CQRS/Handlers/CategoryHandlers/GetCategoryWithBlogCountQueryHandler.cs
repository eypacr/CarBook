using CarBook.Application.Features.CQRS.Results.CategoryResults;
using CarBook.Application.RepositoryInterfaces;

namespace CarBook.Application.Features.CQRS.Handlers.CategoryHandlers;

public class GetCategoryWithBlogCountQueryHandler
{
    private readonly ICategoryRepository _repository;

    public GetCategoryWithBlogCountQueryHandler(ICategoryRepository repository)
    {
        _repository = repository;
    }

    public Task<List<GetCategoryWithBlogCountQueryResult>> Handle()
    {
        var values = _repository.GetCategoryListWithBlogCount();
        var task = values.Select(x => new GetCategoryWithBlogCountQueryResult()
        {
            CategoryId = x.CategoryId,
            BlogCount = x.Blogs.Count,
            Name = x.Name,
        }).ToList();
        return Task.FromResult(task);
    }
}
