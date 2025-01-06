using CarBook.Application.Features.Mediator.Commands.ReservationCommands;
using CarBook.Application.RepositoryInterfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.ReservationHandlers;

public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand>
{
    private readonly IRepository<Reservation> _repository;

    public CreateReservationCommandHandler(IRepository<Reservation> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateReservationCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new Reservation
        {
            Age = request.Age,
            CarId = request.CarId,
            Description = request.Description,
            Email = request.Email,
            DriverLicenseYear = request.DriverLicenseYear,
            DropOffLocationId = request.DropOffLocationId,
            Name = request.Name,
            Phone = request.Phone,
            PickUpLocationId = request.PickUpLocationId,
            Surname = request.Surname,
            ReservationStatusId = 2
        });
    }
}
