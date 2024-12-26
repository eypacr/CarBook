using CarBook.Application.Features.Mediator.Queries.TagCloudQueries;
using CarBook.Application.Features.Mediator.Results.TagCloudResults;
using CarBook.Application.RepositoryInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.TagCloudHandlers;

public class GetTagCloudByBlogIdQueryHandler : IRequestHandler<GetTagCloudByBlogIdQuery, List<GetTagCloudByBlogIdQueryResult>>
{
    private readonly ITagCloudRepository _repository;

    public GetTagCloudByBlogIdQueryHandler(ITagCloudRepository repository)
    {
        _repository = repository;
    }

    public async  Task<List<GetTagCloudByBlogIdQueryResult>> Handle(GetTagCloudByBlogIdQuery request, CancellationToken cancellationToken)
    {
        var values =  _repository.GetTagCloudByBlogId(request.Id);
        return values.Select( x=> new GetTagCloudByBlogIdQueryResult
        {
            BlogId=x.BlogId,
            TagCloudId=x.TagCloudId,
            Title=x.Title
        }).ToList();
    }
}
