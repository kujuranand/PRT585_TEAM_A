using _1CommonInfrastructure.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Validations
{
    public class StudentValidator : BaseValidator<StudentModel>
    {
        public StudentValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                    .WithMessage("This field cannot be empty")
                .MaximumLength(400)
                    .WithMessage("Max Length allowed is (400)")
                ;

            RuleFor(x => x.Email)
                .NotEmpty()
                    .WithMessage(ValidatorMessage.NotEmpty)
                .MaximumLength(400)
                    .WithMessage(ValidatorMessage.MaxLength(400))
                ;

            RuleFor(x => x.Course)
                .MaximumLength(400)
                    .WithMessage(ValidatorMessage.MaxLength(400))
                ;
            //RuleFor(x => x.Phone)
            //    .NotEmpty()
            //        .WithMessage("Phone Number is required.");
            //    .MinimumLength(10).WithMessage("PhoneNumber must not be less than 10 characters.")
            //    .MaximumLength(20).WithMessage("PhoneNumber must not exceed 50 characters.")
            //    .Matches(new Regex(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}")).WithMessage("PhoneNumber not valid");
        }
                
        
    }
}