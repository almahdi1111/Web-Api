using System.ComponentModel.DataAnnotations;

namespace Web_Api.Controllers
{
    public class USER
    {
        public int User_ID { get; set; }
        [StringLength(40, ErrorMessage = "The Name value cannot exceed 40 characters. ")]
        public string User_name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [StringLength(16, ErrorMessage = "Must be between 5 and 50 characters", MinimumLength = 5)]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Must be a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        public string Password { get; set; }


    }
}
