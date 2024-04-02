using System.ComponentModel.DataAnnotations;

namespace msvHarmony.Domain.Models.Identity
{
    public class ResetPasswordRequest
    {
        [Required]        
        public string Password { get; set; }
        
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }        
        public string Email { get; set; }
    }
}
