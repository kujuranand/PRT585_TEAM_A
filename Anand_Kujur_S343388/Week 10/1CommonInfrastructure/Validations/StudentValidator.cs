using _1CommonInfrastructure.Models;
using FluentValidation;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Validations
{  
    public class StudentValidator : BaseValidator<StudentModel>
    {
        public StudentValidator()
        {
            RuleFor(x => x.StudentName)
                .NotEmpty()
            .WithMessage("Required field")
                .MaximumLength(500)
                    .WithMessage("Max allowed character less than 500")
            ;
                   
        }
    }
}
