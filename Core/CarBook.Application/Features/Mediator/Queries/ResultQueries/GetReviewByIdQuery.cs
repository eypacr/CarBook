using CarBook.Application.Features.Mediator.Results.ReviewResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.ResultQueries;

public class GetReviewByIdQuery : IRequest<GetReviewByIdQueryResult>
{
    public int Id { get; set; }

    public GetReviewByIdQuery(int id)
    {
        Id = id;
    }
}