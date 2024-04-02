using MediatR;
using msvHarmony.Domain.Entities;
using msvHarmony.Domain.Ports;
using msvHarmony.Domain.Services;

namespace msvHarmony.Application.Account.Command
{
    public class UpdateAccountHandler : AsyncRequestHandler<UpdateAccountCommand>
    {
        private readonly IUnitOfWorkSecurityDbContext _unitOfWorkSecurityDbContext;
        private readonly IUserRepository _userRepository;
        private readonly AzureBlobService _azureBlobService;

        public UpdateAccountHandler(IUnitOfWorkSecurityDbContext unitOfWorkSecurityDbContext, IUserRepository userRepository, AzureBlobService azureBlobService)
        {
            _unitOfWorkSecurityDbContext = unitOfWorkSecurityDbContext;
            _userRepository = userRepository;
            _azureBlobService = azureBlobService;
        }

        protected override async Task Handle(UpdateAccountCommand request, CancellationToken cancellationToken)
        {
            User user = await _userRepository.SingleUser(request.Id);
            user.Name = request.Name;
            user.Surname = request.Surname;            
            user.PhoneNumber = request.PhoneNumber;
            
            if(request.Photo is not null )
            {
                user.ValidatePhoto(request.Photo);
                await _azureBlobService.UploadFileAsync(request.Photo, user.Id);
            }          
                        
            _userRepository.UpdateUser(user);
            await _unitOfWorkSecurityDbContext.SaveAsync();
        }
    }
}
