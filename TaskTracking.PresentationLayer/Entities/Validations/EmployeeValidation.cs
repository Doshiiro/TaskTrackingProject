using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracking.PresentationLayer.Entities.Validations
{
    public class EmployeeValidation : AbstractValidator<Employee>
    {
        public EmployeeValidation()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı boş geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş geçilemez");
            RuleFor(x => x.DepartmentID).NotEmpty().WithMessage("Departman alanı boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");

            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Kullanıcı Adı 2 karakterden fazla olmalı");
            RuleFor(x => x.Password).MinimumLength(3).WithMessage("Şife alanı 2 karakterden fazla olmalı");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Yanlış bir formatta Email adresi girdiniz");
        }
    }
}
