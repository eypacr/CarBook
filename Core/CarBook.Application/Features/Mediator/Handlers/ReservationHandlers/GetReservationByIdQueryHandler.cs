using CarBook.Application.Features.Mediator.Queries.ReservationQueries;
using CarBook.Application.Features.Mediator.Results.ReservationResults;
using CarBook.Application.RepositoryInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.ReservationHandlers;

public class GetReservationByIdQueryHandler : IRequestHandler<GetReservationByIdQuery, GetReservationByIdQueryResult>
{
    private readonly IReservationRepository _repository;

    public GetReservationByIdQueryHandler(IReservationRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetReservationByIdQueryResult> Handle(GetReservationByIdQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetReservationById(request.Id);
        return new GetReservationByIdQueryResult
        {
            ReservationId = value.ReservationId,
            Name = value.Name,
            ReservationStatusId = value.ReservationStatusId,
            Age = value.Age,
            BrandName = value.Car.Brand.Name,
            Description = value.Description,
            DriverLicenseYear = value.DriverLicenseYear,
            DropOffLocationId = value.DropOffLocationId,
            DropOffLocationName = value.DropOffLocation.Name,
            PickUpLocationId = value.PickUpLocationId,
            PicUpLocationName = value.PickUpLocation.Name,
            CarId = value.CarId,
            Email = value.Email,
            ModelName = value.Car.Model,
            Phone = value.Phone,
            Surname = value.Surname,
            ReservationStatusName = value.ReservationStatus.Name,
            ReservationStatusIcon = value.ReservationStatus.Icon,
        };
    }
}
