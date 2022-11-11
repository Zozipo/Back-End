using Compass.Data.Data.ViewModels.Users;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compass.Data.Validation.Users
{
    public class UpdateUserValidation : AbstractValidator<UpdateUserVM>
    {
        public UpdateUserValidation()
        {
            RuleFor(r => r.Id).NotEmpty();
            RuleFor(r => r.Name).NotEmpty();
            RuleFor(r => r.Surname).NotEmpty();
            RuleFor(r => r.Email).NotEmpty().EmailAddress();
            RuleFor(r => r.Phone).NotEmpty();
            RuleFor(r => r.Role).NotEmpty();
        }
    }
}
