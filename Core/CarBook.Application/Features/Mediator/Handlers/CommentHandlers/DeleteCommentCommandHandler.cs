using CarBook.Application.Features.Mediator.Commands.CommentCommands;
using CarBook.Application.RepositoryInterfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.CommentHandlers;

public class DeleteCommentCommandHandler : IRequestHandler<DeleteCommentCommand>
{
    private readonly IRepository<Comment> _repository;

    public DeleteCommentCommandHandler(IRepository<Comment> repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeleteCommentCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.RemoveAsync(value);
    }
}