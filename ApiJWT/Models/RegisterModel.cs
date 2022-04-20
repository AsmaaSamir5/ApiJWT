using System.ComponentModel.DataAnnotations;

namespace ApiJWT.Models
{
    public class RegisterModel
    {
        [Required,MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        [Required, MaxLength(100)]
        public string UserName { get; set; }

        [Required, MaxLength(130)]
        public string Email { get; set; }

        [Required, MaxLength(256)]
        public string Password { get; set; }


    }
}
