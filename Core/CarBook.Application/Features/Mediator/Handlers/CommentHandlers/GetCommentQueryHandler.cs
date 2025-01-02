using CarBook.Application.Features.Mediator.Queries.CommentQueries;
using CarBook.Application.Features.Mediator.Results.CommentResults;
using CarBook.Application.RepositoryInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.CommentHandlers;

public class GetCommentQueryHandler : IRequestHandler<GetCommentQuery, List<GetCommentQueryResult>>
{
    private readonly ICommentRepository _repository;

    public GetCommentQueryHandler(ICommentRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<GetCommentQueryResult>> Handle(GetCommentQuery request, CancellationToken cancellationToken)
    {
        var values = _repository.GetCommentListWithAllInfo();
        return values.Select(x => new GetCommentQueryResult
        {
            BlogId = x.BlogId,
            CommentId = x.CommentId,
            CreatedDate = x.CreatedDate,
            Name = x.Name,
            Surname = x.Surname,
            Text = x.Text,
            Email = x.Email,
            BlogTitle = x.Blog.Title,
        }).ToList();
    }
}
