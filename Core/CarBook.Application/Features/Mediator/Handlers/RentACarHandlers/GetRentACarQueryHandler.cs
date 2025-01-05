using CarBook.Application.Features.Mediator.Queries.RentACarQueries;
using CarBook.Application.Features.Mediator.Results.RentACarResults;
using CarBook.Application.RepositoryInterfaces;
using MediatR;
using System.Linq;

namespace CarBook.Application.Features.Mediator.Handlers.RentACarHandlers;

public class GetRentACarQueryHandler : IRequestHandler<GetRentACarQuery, List<GetRentACarQueryResult>>
{
    private readonly IRentACarRepository _repository;

    public GetRentACarQueryHandler(IRentACarRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<GetRentACarQueryResult>> Handle(GetRentACarQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByFilterAsync(x => x.LocationId == request.LocationId && x.Available == request.Available);
        var results = values.Select(x => new GetRentACarQueryResult
        {
            CarId = x.CarId,
            BrandName = x.Car.Brand.Name,
            CoverImageUrl = x.Car.CoverImageUrl,
            Model = x.Car.Model,
            PricingAmount = x.Car.CarPricings.Skip(1).FirstOrDefault().Amount,
        }).ToList();
        return results;
    }
}
