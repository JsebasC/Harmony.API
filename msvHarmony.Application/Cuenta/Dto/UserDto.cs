namespace msvHarmony.Application.Dto
{
   public class UserDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }        
        public string? Photo { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
