using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCoreProject1.Models
{
    public class Register
    {
        [Key]
        [ScaffoldColumn(false)]
        public int RegisterId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name cannot be empty!!")]
        [MinLength(2, ErrorMessage = "First Name cannot be less than 2 characters!!")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "First name must contain only letters")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = " Last Name cannot be Empty!!")]
        [MinLength(2, ErrorMessage = "Last Name cannot be less than 2 characters!!")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Last name must contain only letters")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email cannot be empty!!")]
        [EmailAddress]
        [MinLength(2, ErrorMessage = "This field cannot be less than 2 characters!!")]
        public string Email { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "Cannot be empty")]
        [MinLength(2, ErrorMessage = "Username cannot be less than 2 characters")]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage ="Password cannot be Empty")]
        [DataType(DataType.Password)]
        [MinLength(4, ErrorMessage = "Password cannot be less than 4 characters!!")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&./\|'])[A-Za-z\d$@$!%*#?&]{8,}$", ErrorMessage = "Password must contain at least one uppercase, one lowercase, one number, and one special character")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [NotMapped]
        [Compare("Password", ErrorMessage = "Password and confirm password did not match!!")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [ScaffoldColumn(false)]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}
