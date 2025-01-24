using System.ComponentModel.DataAnnotations;

namespace FinalProject.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Fullname is required.")]
        [Display(Name = "Fullname")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Identification Number is required")]
        [Display(Name = "ID Number")]
        [StringLength(11)]
        public string IdNumber { get; set; }
        
        [Required(ErrorMessage = "Phone Number is required")]
        [Display(Name = "Phone Number")]
        [StringLength(11)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "The {0} must be at {2} and at max {1} characters long.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword", ErrorMessage = "Password does not match.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
