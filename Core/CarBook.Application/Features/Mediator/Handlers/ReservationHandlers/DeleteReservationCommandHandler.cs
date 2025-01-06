using CarBook.Application.Features.Mediator.Commands.ReservationCommands;
using CarBook.Application.RepositoryInterfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBookProject.Application.Features.Mediator.Handlers.ReservationHandlers;

public class DeleteReservationCommandHandler : IRequestHandler<DeleteReservationCommand>
{
    private readonly IRepository<Reservation> _repository;

    public DeleteReservationCommandHandler(IRepository<Reservation> repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeleteReservationCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.RemoveAsync(value);
    }
}
