using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.ReservationCommands;

public class DeleteReservationCommand : IRequest
{
    public int Id { get; set; }

    public DeleteReservationCommand(int id)
    {
        Id = id;
    }
}
