﻿using CourseLibrary.API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.ValidationAttributes
{
    public class CourseTitleMustBeDifferentFromDescriptionAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var course = (CourseForCreationDto)validationContext.ObjectInstance;

            if (course.Title == course.Description)
            {
                // ErrorMessage will get it from the Dto
                return new ValidationResult(ErrorMessage, new[] { nameof(CourseForManipulationDto) });
            }

            return ValidationResult.Success;
        }
    }
}