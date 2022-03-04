using FluentValidation;
using StudentLibrary.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLibrary.Api.Validators
{
    public class AuthorUpdateDtoValidator:AbstractValidator<AuthorUpdateDto>
    {
        public AuthorUpdateDtoValidator()
        {
            RuleFor(x => x.Id).NotNull().WithMessage("Id alanı boş geçilemez");
            RuleFor(x => x.Name).NotNull().WithMessage("Name alanı boş geçilemez");
            RuleFor(x => x.Surname).NotNull().WithMessage("Surname alanı boş geçilemez");
        }
    }
}
