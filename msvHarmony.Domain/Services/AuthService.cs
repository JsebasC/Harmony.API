using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using msvHarmony.Domain.Constants;
using msvHarmony.Domain.Entities;
using msvHarmony.Domain.Models.Identity;
using msvHarmony.Domain.Ports;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace msvHarmony.Domain.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly JwtSettings _jwtSettings;

        public AuthService(UserManager<User> userManager, SignInManager<User> signInManager, IOptions<JwtSettings> jwtSettings)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtSettings = jwtSettings.Value;
        }

        public async Task<AuthResponse> LoginAsync(AuthRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.User);            
            if (user is null)
                throw new Exception($"El usuario {request.User} no existe");

            var resultado = await _signInManager.PasswordSignInAsync(user, request.Password, false, lockoutOnFailure: false);
            if (!resultado.Succeeded)
                throw new Exception($"Las credenciales son incorrectas");

            var token = await GenerateToken(user);
            return new AuthResponse
            {
                Id = user.Id,
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                ExpirationToken = token.Payload.Exp,
                Email = user.Email,
                Username = user.UserName,
                Photo = user.Photo
            };
        }

        public async Task<RegistrationResponse> RegisterAsync(RegistrationRequest request)
        {
            var existingUser = await _userManager.FindByNameAsync(request.Username);
            if (existingUser != null)
                throw new Exception($"El usuario ya fue tomado por otra cuenta");

            var existingEmail = await _userManager.FindByEmailAsync(request.Email);
            if (existingEmail != null)
                throw new Exception($"El email ya fue tomado por otra cuenta");

            var user = new User
            {
                UserName = request.Username,
                Email = request.Email,
                EmailConfirmed = true
            };

            var resultado = await _userManager.CreateAsync(user, request.Password);
            if (resultado.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "usuario_eco_comprometido");
                var token = await GenerateToken(user);

                return new RegistrationResponse
                {
                    Email = user.Email,
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    UserId = user.Id,
                    Username = user.UserName
                };
            }

            throw new Exception($"{resultado.Errors}");
        }

        public async Task ForgotPasswordAsync(ForgotPasswordRequest request)
        {
            await ValidateUserByEmailAsync(request.Email);
        }

        public async Task ResetPasswordAsync(ResetPasswordRequest request)
        {
            var user = await ValidateUserByEmailAsync(request.Email);
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);

            var resultado = await _userManager.ResetPasswordAsync(user, token, request.Password);

            if (!resultado.Succeeded)
                throw new Exception($"{resultado.Errors}");
        }

        private async Task<User> ValidateUserByEmailAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user is null)
                throw new Exception($"El usuario con email {email} no existe");

            return user;
        }

        private async Task<JwtSecurityToken> GenerateToken(User user)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);

            var roleClaims = new List<Claim>();

            foreach (var rol in roles)
            {
                roleClaims.Add(new Claim(ClaimTypes.Role, rol));
            }

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(CustomClaimTypes.Uid, user.Id)
            }.Union(userClaims).Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_jwtSettings.DurationInMinutes),
                signingCredentials: signingCredentials
                );

            return jwtSecurityToken;
        }
    }
}
