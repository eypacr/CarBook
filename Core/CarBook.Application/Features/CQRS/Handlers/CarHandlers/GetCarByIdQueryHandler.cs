using CarBook.Application.Features.CQRS.Queries.CarQueries;
using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.RepositoryInterfaces;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers;

public class GetCarByIdQueryHandler
{
    private readonly ICarRepository _repository;

    public GetCarByIdQueryHandler(ICarRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
    {
        var values = _repository.GetCarById(query.Id);

        return new GetCarByIdQueryResult
        {
            BrandId = values.BrandId,
            BigImageUrl = values.BigImageUrl,
            CoverImageUrl = values.CoverImageUrl,
            Fuel = values.Fuel,
            CarId = values.CarId,
            Km = values.Km,
            Luggage = values.Luggage,
            Model = values.Model,
            Seat = values.Seat,
            Transmission = values.Transmission,
            // CarDescriptions listesindeki Details alanlarını birleştiriyoruz.
            Description = string.Join(",", values.CarDescriptions.Select(cd => cd.Details))
        };
    }
}
