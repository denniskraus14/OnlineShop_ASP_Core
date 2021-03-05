using System.ComponentModel.DataAnnotations;

namespace OnlineShop.ViewModel.AccountViews {
    public class RegistrationViewModel {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and conrfirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
