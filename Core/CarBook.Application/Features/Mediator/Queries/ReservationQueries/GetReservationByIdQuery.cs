using CarBook.Application.Features.Mediator.Results.ReservationResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.ReservationQueries;

public class GetReservationByIdQuery : IRequest<GetReservationByIdQueryResult>
{
    public int Id { get; set; }

    public GetReservationByIdQuery(int id)
    {
        Id = id;
    }
}
