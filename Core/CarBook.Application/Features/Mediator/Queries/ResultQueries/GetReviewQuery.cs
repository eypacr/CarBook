using CarBook.Application.Features.Mediator.Results.ReviewResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.ResultQueries;

public class GetReviewQuery : IRequest<List<GetReviewQueryResult>>
{
}