using System;
using System.ComponentModel.DataAnnotations;
using DotNetCoreProject1.Models;

namespace DotNetCoreProject1.Validators
{
    public class MyCustomValidationAttribute : ValidationAttribute
    {
        public MyCustomValidationAttribute()
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Car c = (Car)validationContext.ObjectInstance;
            return base.IsValid(value, validationContext);
        }
    }
}
