using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.CommentCommands;

public class CreateCommentCommand : IRequest
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Text { get; set; }
    public string Email { get; set; }
    public DateTime CreatedDate { get; set; }
    public int BlogId { get; set; }
}
