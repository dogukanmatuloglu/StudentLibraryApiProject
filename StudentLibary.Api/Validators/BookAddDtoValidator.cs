using FluentValidation;
using StudentLibrary.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLibrary.Api.Validators
{
    public class BookAddDtoValidator:AbstractValidator<BookAddDto>
    {
        public BookAddDtoValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Name alanı boş geçilemez");
            RuleFor(x => x.IsbnNo).NotNull().WithMessage("ISBNO alanı boş geçilemez");
            RuleFor(x => x.Page).NotNull().WithMessage("Page alanı boş geçilemez");
           
        }
    }
}
