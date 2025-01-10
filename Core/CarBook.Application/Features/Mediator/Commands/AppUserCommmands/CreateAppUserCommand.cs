using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.AppUserCommmands;

public class CreateAppUserCommand : IRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
}
