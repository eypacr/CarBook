using CarBook.Application.Features.Mediator.Commands.CommentCommands;
using CarBook.Application.RepositoryInterfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.CommentHandlers;

public class UpdateCommentCommandHandler : IRequestHandler<UpdateCommentCommand>
{
    private readonly IRepository<Comment> _repository;

    public UpdateCommentCommandHandler(IRepository<Comment> repository)
    {
        _repository = repository;
    }
    public async Task Handle(UpdateCommentCommand request, CancellationToken cancellationToken)
    {

        var value = await _repository.GetByIdAsync(request.CommentId);
        if (value==null)
        {
            throw new KeyNotFoundException($"Yorum ID {request.CommentId} bulunamadı.");
        }
        value.Surname = request.Surname;
        value.Name = request.Name;
        value.Text = request.Text;
        value.BlogId = request.BlogId;
        value.Email = request.Email;
        await _repository.UpdateAsync(value);
    }
}