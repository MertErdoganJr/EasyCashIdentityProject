using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Bu Alan Boş Bırakılamaz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Bu Alan Boş Bırakılamaz");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Bu Alan Boş Bırakılamaz");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Bu Alan Boş Bırakılamaz");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Bu Alan Boş Bırakılamaz");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Bu Alan Boş Bırakılamaz");

            RuleFor(x => x.Name).MaximumLength(30).WithMessage("En Fazla 30 Karakter Girişi Yapınız");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("En Az 2 Karakter Girişi Yapınız");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Parolalarınız Eşleşmiyor");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen Geçerli Bir Mail Adresi Giriniz");
        }
    }
}
