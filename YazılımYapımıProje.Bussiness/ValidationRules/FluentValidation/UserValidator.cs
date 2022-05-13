using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using YazılımYapımıProje.Entities.Concrete;

namespace YazılımYapımıProje.Bussiness.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<Users>
    {
        public UserValidator()
        {
            RuleFor(p => p.UserName).NotEmpty().WithMessage("Boş olamaz");
            RuleFor(p => p.UserSurname).NotEmpty().WithMessage("Boş olamaz");
            RuleFor(p => p.UserEMail).NotEmpty().WithMessage("Boş olamaz");
            RuleFor(p => p.UserPassword).NotEmpty().WithMessage("Boş olamaz");
        }
    }
}
