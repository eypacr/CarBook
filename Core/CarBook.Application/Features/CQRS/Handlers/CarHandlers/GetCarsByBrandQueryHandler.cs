using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.RepositoryInterfaces;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers;

public class GetCarsByBrandQueryHandler
{
    private readonly ICarRepository _repository;

    public GetCarsByBrandQueryHandler(ICarRepository repository)
    {
        _repository = repository;
    }

    public List<GetCarsByBrandQueryResult> Handle(int id)
    {
        var cars = _repository.GetCarsByBrand(id);
        if (cars == null || !cars.Any())
        {
            throw new KeyNotFoundException($"Marka Id'si {id} olan Araç ya da Araçlar bulunamadı.");
        }
        return cars.Select(x => new GetCarsByBrandQueryResult
        {
            BrandName = x.Brand.Name,
            BrandId = x.BrandId,
            BigImageUrl = x.BigImageUrl,
            CarId = x.CarId,
            CoverImageUrl = x.CoverImageUrl,
            Fuel = x.Fuel,
            Km = x.Km,
            Luggage = x.Luggage,
            Model = x.Model,
            Seat = x.Seat,
            Transmission = x.Transmission
        }).ToList();
    }
}
