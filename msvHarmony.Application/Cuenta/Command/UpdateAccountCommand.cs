using MediatR;
using Microsoft.AspNetCore.Http;

namespace msvHarmony.Application.Account.Command
{
    public record UpdateAccountCommand(Guid Id, string Name, string Surname, string PhoneNumber, IFormFile? Photo) : IRequest;
}
