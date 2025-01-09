using CarBook.Application.Features.Mediator.Commands.CarFeatureCommands;
using CarBook.Application.RepositoryInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.CarFeatureHandlers;

public class UpdateCarFeatureAvailableChangeToTrueCommandHandler : IRequestHandler<UpdateCarFeatureAvailableChangeToTrueCommand>
{
    private readonly ICarFeatureRepository _repository;

    public UpdateCarFeatureAvailableChangeToTrueCommandHandler(ICarFeatureRepository repository)
    {
        _repository = repository;
    }
    public async Task Handle(UpdateCarFeatureAvailableChangeToTrueCommand request, CancellationToken cancellationToken)
    {
        _repository.ChangeCarFeatureAvaiableToTrue(request.Id);

    }
}
