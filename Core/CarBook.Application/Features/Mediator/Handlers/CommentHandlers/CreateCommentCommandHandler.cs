using CarBook.Application.Features.Mediator.Commands.CommentCommands;
using CarBook.Application.RepositoryInterfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.CommentHandlers;

public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand>
{
    private readonly IRepository<Comment> _repository;

    public CreateCommentCommandHandler(IRepository<Comment> repository)
    {
        _repository = repository;
    }
    public async Task Handle(CreateCommentCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new Comment
        {
            Name = request.Name,
            Surname = request.Surname,
            CreatedDate = request.CreatedDate,
            Text = request.Text,
            BlogId = request.BlogId,
            Email = request.Email,
        });
    }
}
