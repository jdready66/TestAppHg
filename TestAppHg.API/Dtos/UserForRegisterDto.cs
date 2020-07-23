using System.ComponentModel.DataAnnotations;

namespace TestAppHg.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength=4)]
        public string Password { get; set; }
    }

}