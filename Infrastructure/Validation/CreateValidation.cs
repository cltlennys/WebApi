﻿using Core.DTOs;
using FluentValidation;

namespace WebApi.Validation
{
    public class CreateValidation : AbstractValidator<CreateCustomerDTO>
    {
        public CreateValidation()
        {
            RuleFor(c => c.FirstName).Length(3, 40);

            RuleFor(c => c.LastName).Length(3, 40);

            RuleFor(c => c.Email).EmailAddress();

            RuleFor(c => c.Phone).Length(12, 15);

            RuleFor(c => c.BirthDate).NotEmpty();



           
        }
    }
}
