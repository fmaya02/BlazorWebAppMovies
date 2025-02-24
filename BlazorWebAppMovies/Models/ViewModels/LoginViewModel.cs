using System.ComponentModel.DataAnnotations;

namespace BlazorWebAppMovies.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Por favor ingrese un nombre de usuario")]
        public string? UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Por favor ingrese una contraseña")]
        public string? Password { get; set; }
    }
}
