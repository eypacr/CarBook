using CarBook.Application.Features.Mediator.Queries.CarFeatureQueries;
using CarBook.Application.Features.Mediator.Results.CarFeatureResults;
using CarBook.Application.RepositoryInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.CarFeatureHandlers;

public class GetCarFeatureByCarIdQueryHandler : IRequestHandler<GetCarFeatureByCarIdQuery, List<GetCarFeatureByCarIdQueryResult>>
{
    private readonly ICarFeatureRepository _repository;

    public GetCarFeatureByCarIdQueryHandler(ICarFeatureRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<GetCarFeatureByCarIdQueryResult>> Handle(GetCarFeatureByCarIdQuery request, CancellationToken cancellationToken)
    {
        var values = _repository.GetCarFeatureListByCarId(request.Id);
        return values.Select(x => new GetCarFeatureByCarIdQueryResult
        {
            CarFeatureId = x.CarFeatureId,
            CarId = x.CarId,
            Available = x.Available,
            FeatureId = x.FeatureId,
            FeatureName = x.Feature.Name
        }).ToList();
    }
}
