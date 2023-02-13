using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name ="Fecha de cumpleaños")]

        public string BirthDate { get; set; }
    }
}
