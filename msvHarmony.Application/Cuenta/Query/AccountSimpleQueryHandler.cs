using MediatR;
using msvHarmony.Application.Dto;
using msvHarmony.Domain.Entities;
using msvHarmony.Domain.Ports;

namespace msvHarmony.Application.Account.Query
{
    public class AccountSimpleQueryHandler : IRequestHandler<AccountSimpleQuery, UserDto>
    {
        private readonly IUserRepository _userRepository;

        public AccountSimpleQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserDto> Handle(AccountSimpleQuery request, CancellationToken cancellationToken)
        {
            User user = await _userRepository.SingleUser(request.uid);

            UserDto userDto = new()
            {
                Id = Guid.Parse(user.Id),
                Name = user.Name,
                Surname = user.Surname,                         
                Photo = user.Photo,
                PhoneNumber = user.PhoneNumber
            };

            return userDto;
        }
    }
}
