using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class UserRegistrationModel
    {
        [Required(ErrorMessage = "Nombre requerido")]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Fecha de nacimiento requerida")]
        [Display(Name = "Fecha de nacimiento")]
        public string BirthDate { get; set; }


        [Required(ErrorMessage = "Correo electronico requerido")]
        [Display(Name = "Correo electrónico")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password es requerido")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "El password and confirmaciòn de password no son iguales")]
        public string ConfirmPassword { get; set; }
    }
}
