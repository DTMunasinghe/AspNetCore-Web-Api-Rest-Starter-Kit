using System.ComponentModel.DataAnnotations;

namespace SampleApi.ViewModels
{
    public class UserPasswordViewModel
    {
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        [Required]
        [MinLength(8)]
        public string NewPassword { get; set; }
    }
}