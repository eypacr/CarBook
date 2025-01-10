using CarBook.Application.Features.Mediator.Queries.ResultQueries;
using CarBook.Application.Features.Mediator.Results.ReviewResults;
using CarBook.Application.RepositoryInterfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.ReviewHandlers;

public class GetReviewByIdQueryHandler : IRequestHandler<GetReviewByIdQuery, GetReviewByIdQueryResult>
{
    private readonly IRepository<Review> _repository;

    public GetReviewByIdQueryHandler(IRepository<Review> repository)
    {
        _repository = repository;
    }

    public async Task<GetReviewByIdQueryResult> Handle(GetReviewByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        return new GetReviewByIdQueryResult
        {
            ReviewId = value.ReviewId,
            Name = value.Name,
            CreatedDate = value.CreatedDate,
            Text = value.Text,
            Surname = value.Surname,
            IsApproved = value.IsApproved,
            ImageUrl = value.ImageUrl,
            Email = value.Email,
            CarId = value.CarId,
        };
    }
}