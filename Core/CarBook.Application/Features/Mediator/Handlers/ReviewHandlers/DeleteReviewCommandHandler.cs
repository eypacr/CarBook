using CarBook.Application.Features.Mediator.Commands.ReviewCommands;
using CarBook.Application.RepositoryInterfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.ReviewHandlers;

public class DeleteReviewCommandHandler : IRequestHandler<DeleteReviewCommand>
{
    private readonly IRepository<Review> _repository;

    public DeleteReviewCommandHandler(IRepository<Review> repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeleteReviewCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.RemoveAsync(value);
    }
}