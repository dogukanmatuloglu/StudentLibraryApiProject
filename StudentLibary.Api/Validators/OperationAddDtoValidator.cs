using FluentValidation;
using StudentLibrary.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLibrary.Api.Validators
{
    public class OperationAddDtoValidator:AbstractValidator<OperationAddDto>
    {
        public OperationAddDtoValidator()
        {
            RuleFor(x => x.Book).NotNull().WithMessage("Book alanı boş geçilemez");
            RuleFor(x => x.Student).NotNull().WithMessage("Student alanı boş geçilemez");
            RuleFor(x => x.GDate).NotNull().WithMessage("Veriliş Tarihi alanı boş geçilemez");
            RuleFor(x => x.TDate).NotNull().WithMessage("Alınış Tarihi alanı boş geçilemez");

        }
    }
}
