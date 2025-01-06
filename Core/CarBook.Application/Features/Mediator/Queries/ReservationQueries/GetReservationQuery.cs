using CarBook.Application.Features.Mediator.Results.ReservationResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.ReservationQueries;

public class GetReservationQuery : IRequest<List<GetReservationQueryResult>>
{
}
