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
    public class SubjectValidator : BaseValidator<SubjectModel>
    {
        public SubjectValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                    .WithMessage("This field cannot be empty")
                .MaximumLength(400)
                    .WithMessage("Max Length allowed is (400)")
                ;

            RuleFor(x => x.Code)
                .NotEmpty()
                    .WithMessage("This field cannot be empty")
                .MaximumLength(400)
                    .WithMessage("Max Length allowed is (400)")
                ;

      

            //RuleFor(x => x.Duration)
            //    .NotEmpty()
            //        .WithMessage(ValidatorMessage.NotEmpty)
            //    .MaximumLength(400)
            //        .WithMessage(ValidatorMessage.MaxLength(400))
            //    ;

        }
                
        
    }
}