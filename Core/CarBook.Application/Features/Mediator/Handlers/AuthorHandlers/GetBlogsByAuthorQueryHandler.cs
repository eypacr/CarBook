using CarBook.Application.Features.Mediator.Queries.AuthorQueries;
using CarBook.Application.Features.Mediator.Results.AuthorResults;
using CarBook.Application.RepositoryInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.AuthorHandlers;

public class GetBlogsByAuthorQueryHandler : IRequestHandler<GetBlogsByAuthorQuery, List<GetBlogsByAuthorQueryResult>>
{
    private readonly IAuthorRepository _repository;

    public GetBlogsByAuthorQueryHandler(IAuthorRepository repository) =>
        _repository = repository;

    public async Task<List<GetBlogsByAuthorQueryResult>> Handle(GetBlogsByAuthorQuery request, CancellationToken cancellationToken)
    {
        // GetBlogsByAuthorAsync metodu bir Author nesnesi döndürmelidir.
        var authors = await _repository.GetBlogsByAuthorAsync(request.Id);

        // Eğer yazar bulunamazsa, boş liste döndür
        if (authors == null)
        {
            return new List<GetBlogsByAuthorQueryResult>();
        }

        // Yazarın blogları üzerinde dönüp gerekli dönüşümü yapıyoruz
        return authors.Blogs.Select(blog => new GetBlogsByAuthorQueryResult
        {
            BlogId = blog.BlogId,  // BlogId
            Title = blog.Title,  // Blog başlığı
            Description = blog.Description,  // Blog açıklaması
            CoverImageUrl = blog.CoverImageUrl,  // Blog kapak resmi
            CreatedDate = blog.CreatedDate  // Blog oluşturulma tarihi
        }).ToList();
    }

}
