using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.ViewModels.Validations;

namespace WebAPI.ViewModels
{
    [Validator(typeof(RegistrationViewModelValidator))]
    public class RegistrationViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
    }
}
