using CarBook.Application.Features.Mediator.Queries.CommentQueries;
using CarBook.Application.Features.Mediator.Results.CommentResults;
using CarBook.Application.RepositoryInterfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.CommentHandlers;

public class GetCommentByIdQueryHandler : IRequestHandler<GetCommentByIdQuery, GetCommentByIdQueryResult>
{
    private readonly ICommentRepository _repository;

    public GetCommentByIdQueryHandler(ICommentRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetCommentByIdQueryResult> Handle(GetCommentByIdQuery request, CancellationToken cancellationToken)
    {
        var value =await _repository.GetByCommentIdAsync(request.Id);
        if (value == null)
        {
            throw new KeyNotFoundException($"Yorum ID {request.Id} bulunamadı.");
        }
        return new GetCommentByIdQueryResult
        {
            BlogId = value.BlogId,
            CommentId = value.CommentId,
            CreatedDate = value.CreatedDate,
            Name = value.Name,
            Surname = value.Surname,
            Text = value.Text,
            Email = value.Email,
            BlogTitle = value.Blog.Title,
        };
    }
}