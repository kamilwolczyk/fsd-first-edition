using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Fsd.Cs.Web.Validators
{
    public class PasswordValidatorAttribute : ValidationAttribute
    {
        private int _max;
        private int _min;

        public PasswordValidatorAttribute(int min, int max)
        {
            _min = min;
            _max = max;
        }

        public override bool IsValid(object value)
        {
            string password = value as string;

            if (password.Length < _min || password.Length > _max)
                return false;

            if (password.Where(c => Char.IsDigit(c)).Count() < 2)
                return false;

            if (password.Where(c => Char.IsLetter(c)).Count() < 4)
                return false;

            if (password.Where(c => Char.IsUpper(c)).Count() < 1)
                return false;

            return true;
        }
    }
}