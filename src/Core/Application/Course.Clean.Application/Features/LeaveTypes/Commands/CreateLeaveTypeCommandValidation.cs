using Course.Clean.Domain.Entities;

using FluentValidation;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Clean.Application.Features.LeaveTypes.Commands
{
    public class CreateLeaveTypeCommandValidation : AbstractValidator<CreateLeaveTypeCommand>
    {
        public CreateLeaveTypeCommandValidation()
        {
            RuleFor(a => a.Name).NotEmpty().NotNull().WithMessage("اسم نوع الاجازة مطلوب");
            RuleFor(v => v.Name).Must(a => !string.IsNullOrWhiteSpace(a) && a.Length <= 30).WithMessage("أدخل اسم نوع الاجازة بما لا يتجاوز 30 حرف");
        }
    }
}
