using System.ComponentModel.DataAnnotations;

namespace OnlineShop.ViewModel.Account {
    public class LoginViewModel {
        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }

        /// <summary>
        /// This will store the url to return back to.
        /// </summary>
        public string ReturnUrl { get; set; }
    }
}
