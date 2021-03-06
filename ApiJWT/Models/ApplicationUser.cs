using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ApiJWT.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Required,MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}
