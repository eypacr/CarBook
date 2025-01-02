using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.CommentCommands;

public class DeleteCommentCommand : IRequest
{

    public int Id { get; set; }

    public DeleteCommentCommand(int id)
    {
        Id = id;
    }
}
