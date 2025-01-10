using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.ReviewCommands;

public class DeleteReviewCommand : IRequest
{
    public int Id { get; set; }

    public DeleteReviewCommand(int id)
    {
        Id = id;
    }
}