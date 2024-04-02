using msvHarmony.Domain.Models.Identity;

namespace msvHarmony.Domain.Ports
{
    public interface IAuthService
    {        
        Task<AuthResponse> LoginAsync(AuthRequest request);
        Task<RegistrationResponse> RegisterAsync(RegistrationRequest request);
        Task ForgotPasswordAsync(ForgotPasswordRequest request);
        Task ResetPasswordAsync(ResetPasswordRequest request);
    }
}
