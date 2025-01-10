using CarBook.Application.Enums;
using CarBook.Application.Features.Mediator.Commands.AppUserCommmands;
using CarBook.Application.RepositoryInterfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.AppUserHandlers;

public class CreateAppUserCommandHandler : IRequestHandler<CreateAppUserCommand>
{
    private readonly IRepository<AppUser> _appUserRepository;

    public CreateAppUserCommandHandler(IRepository<AppUser> appUserRepository)
    {
        _appUserRepository = appUserRepository;
    }

    public async Task Handle(CreateAppUserCommand request, CancellationToken cancellationToken)
    {
        await _appUserRepository.CreateAsync(new AppUser
        {
            AppRoleId = (int)RolesType.Member, //Enum kullanımı
            Username =request.Username,
            Password=request.Password,
            Email=request.Email,
            Name = request.Name,
            Surname = request.Surname,
        });

    }
}
