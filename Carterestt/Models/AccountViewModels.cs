using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Carterestt.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "EMAIL")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Парола")]
        public string Password { get; set; }

        [Display(Name = "Запази")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Еmail")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Стойността {0} трябва да съдържа поне {2} знака.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Парола")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Потвърдете парола")]
        [Compare("Password", ErrorMessage = "Моля, проверете правилно ли сте написали паролата")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Стойността {0} трябва да съдържа поне {2} знака.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Паролa")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "потвърдете парола")]
        [Compare("Password", ErrorMessage = "Моля, проверете правилно ли сте написали паролата")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Поща")]
        public string Email { get; set; }
    }
}
