using CarBook.Application.Features.Mediator.Results.CarFeatureResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.CarFeatureQueries;

public class GetByIdQuery : IRequest<GetByIdQueryResult>
{
    public int Id { get; set; }

    public GetByIdQuery(int id)
    {
        Id = id;
    }
}