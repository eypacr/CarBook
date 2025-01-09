using CarBook.Application.Features.Mediator.Queries.CarFeatureQueries;
using CarBook.Application.Features.Mediator.Results.CarFeatureResults;
using CarBook.Application.RepositoryInterfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.CarFeatureHandlers;

public class GetByIdQueryHandler : IRequestHandler<GetByIdQuery, GetByIdQueryResult>
{
    private readonly ICarFeatureRepository _repository;

    public GetByIdQueryHandler(ICarFeatureRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetByIdQueryResult> Handle(GetByIdQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetFeatureWithAllInfoById(request.Id); 
        if (values == null)
        {
            return null;
        }

        return new GetByIdQueryResult
        {
            CarFeatureId = values.CarFeatureId, 
            CarId = values.CarId,
            Available = values.Available,
            FeatureId = values.FeatureId,
            FeatureName = values.Feature.Name ,
            CarName=values.Car.Model
        };
    }
}
