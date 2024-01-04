using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracking.PresentationLayer.Entities.Validations
{
    public class DepartmanValidation : AbstractValidator<Department>
    {
        public DepartmanValidation()
        {
            RuleFor(x => x.DepartmentName).NotEmpty().WithMessage("Departman adı boş geçilemez");
            RuleFor(x => x.DepartmentName).MinimumLength(2).WithMessage("Kullanıcı Adı 2 karakterden az olamaz ");
        }
    }
}
