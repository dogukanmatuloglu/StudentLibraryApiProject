using FluentValidation;
using StudentLibrary.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLibrary.Api.Validators
{
    public class StudentAddDtoValidator:AbstractValidator<StudentAddDto>
    {
        public StudentAddDtoValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Name alanı boş geçilemez");
            RuleFor(x => x.Surname).NotNull().WithMessage("Surname alanı boş geçilemez");
            RuleFor(x => x.Class).NotNull().WithMessage("Class alanı boş geçilemez");
            RuleFor(x => x.StudentNo).NotNull().WithMessage("Studentno alanı boş geçilemez");
        }
    }
}
