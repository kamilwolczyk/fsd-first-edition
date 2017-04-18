using System.ComponentModel.DataAnnotations;

namespace Fsd.Kamil.Cs.Ex4.Web.Models.Users
{
    public class UserModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}