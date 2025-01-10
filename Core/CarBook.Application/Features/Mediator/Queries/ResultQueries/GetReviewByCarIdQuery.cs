using CarBook.Application.Features.Mediator.Results.ReviewResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.ResultQueries;

public class GetReviewByCarIdQuery : IRequest<List<GetReviewByCarIdQueryResult>>
{
    public int Id { get; set; }

    public GetReviewByCarIdQuery(int ıd)
    {
        Id = ıd;
    }
}