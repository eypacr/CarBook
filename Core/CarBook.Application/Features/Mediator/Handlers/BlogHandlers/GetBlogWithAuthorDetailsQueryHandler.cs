using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.RepositoryInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogWithAuthorDetailsQueryHandler : IRequestHandler<GetBlogWithAuthorDetailsQuery, List<GetBlogWithAuthorDetailsQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetBlogWithAuthorDetailsQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogWithAuthorDetailsQueryResult>> Handle(GetBlogWithAuthorDetailsQuery request, CancellationToken cancellationToken)
        {
            
            var value = await _repository.GetBlogWithAllInfoById(request.Id);

           
            return value.Select(x => new GetBlogWithAuthorDetailsQueryResult
            {
                AuthorId = x.AuthorID,
                AuthorName = x.Author.Name,
                BlogId = x.BlogId,
                AuthorDescription = x.Author.Description,
                AuthorImageUrl = x.Author.ImageUrl,
            }).ToList();
        }
    }
}
