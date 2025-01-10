using CarBook.Application.Features.Mediator.Queries.ResultQueries;
using CarBook.Application.Features.Mediator.Results.ReviewResults;
using CarBook.Application.RepositoryInterfaces;
using MediatR;

namespace CarBookProject.Application.Features.Mediator.Handlers.ReviewHandlers;

public class GetReviewQueryByCarIdHandler : IRequestHandler<GetReviewByCarIdQuery, List<GetReviewByCarIdQueryResult>>
{
    private readonly IReviewRepository _repository;

    public GetReviewQueryByCarIdHandler(IReviewRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<GetReviewByCarIdQueryResult>> Handle(GetReviewByCarIdQuery request, CancellationToken cancellationToken)
    {
        var values = _repository.GetReviewListByCarId(request.Id);
        return values.Select(x => new GetReviewByCarIdQueryResult()
        {
            ReviewId = x.ReviewId,
            Name = x.Name,
            Email = x.Email,
            ImageUrl = x.ImageUrl,
            IsApproved = x.IsApproved,
            Surname = x.Surname,
            Text = x.Text,
            CreatedDate = x.CreatedDate,
            CarId=x.CarId,
        }).ToList();
    }
}