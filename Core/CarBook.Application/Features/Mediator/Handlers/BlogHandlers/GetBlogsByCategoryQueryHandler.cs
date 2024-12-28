using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.RepositoryInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers;

public class GetBlogsByCategoryQueryHandler : IRequestHandler<GetBlogsByCategoryQuery, List<GetBlogsByCategoryQueryResult>>
{
    private readonly IBlogRepository _repository;

    public GetBlogsByCategoryQueryHandler(IBlogRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<GetBlogsByCategoryQueryResult>> Handle(GetBlogsByCategoryQuery request, CancellationToken cancellationToken)
    {
        // Kategoriye ait blogları alıyoruz
        var blogs = await _repository.GetBlogsByCategoryAsync(request.Id);

        return blogs.Select(blog => new GetBlogsByCategoryQueryResult
        {
            BlogId = blog.BlogId,
            Title = blog.Title,
            Description = blog.Description,
            CoverImageUrl = blog.CoverImageUrl,
            AuthorId = blog.Author.AuthorId,
            AuthorName = blog.Author.Name,
            AuthorImageUrl = blog.Author.ImageUrl
        }).ToList();
    }
}
