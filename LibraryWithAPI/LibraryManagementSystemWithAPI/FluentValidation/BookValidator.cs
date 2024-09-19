using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using LibraryManagementSystemWithAPI.Models;

namespace LibraryManagementSystemWithAPI.FluentValidation
{
    internal class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            //Rules For Book Name
            RuleFor(b => b.Name).NotEmpty().WithMessage("Can NOT Empty");
            RuleFor(b => b.Name).MaximumLength(30).WithMessage("Should be less than 30");
            //Rules For Author
            RuleFor(b => b.Author).MinimumLength(5).WithMessage("Should be more than 5");
            RuleFor(b => b.Author).NotEmpty().WithMessage("Can NOT Empty");
            RuleFor(b => b.Author).MaximumLength(30).WithMessage("Should be less than 30");
            //Rules For Stock
            RuleFor(b => b.Stock).GreaterThan(0).WithMessage("Should be greater than 0");
        }
    }
}
