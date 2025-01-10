using CarBook.Application.Features.Mediator.Commands.ReviewCommands;
using CarBook.Application.RepositoryInterfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.ReviewHandlers;

public class CreateReviewCommandHandler : IRequestHandler<CreateReviewCommand>
{
    private readonly IRepository<Review> _repository;

    public CreateReviewCommandHandler(IRepository<Review> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateReviewCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new Review
        {
            Name = request.Name,
            CreatedDate = request.CreatedDate,
            Email = request.Email,
            ImageUrl = request.ImageUrl,
            IsApproved = request.IsApproved,
            Surname = request.Surname,
            Text = request.Text,
            CarId = request.CarId,
        });
    }
}