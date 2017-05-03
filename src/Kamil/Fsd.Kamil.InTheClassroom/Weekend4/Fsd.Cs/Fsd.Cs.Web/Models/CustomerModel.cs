using Fsd.Cs.Web.Validators;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Fsd.Cs.Web.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }

        [DisplayName("Imię")]
        public string FirstName { get; set; }

        [DisplayName("Nazwisko")]
        [Required(ErrorMessage = "Nazwisko nie może być puste")]
        public string LastName { get; set; }

        [DisplayName("Wiek")]
        [Range(18, 120, ErrorMessage = "Wiek jest niepoprawny")]
        public int Age { get; set; }

        [DisplayName("Adres email")]
        [EmailAddress(ErrorMessage = "Email jest nieprawidłowy")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Imię")]
        [DataType(DataType.Password)]
        [PasswordValidator(6,10, ErrorMessage = "Hasło jest zbyt słabe")]
        public string Password { get; set; }
    }
}