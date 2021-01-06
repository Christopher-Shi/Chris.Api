using System.ComponentModel.DataAnnotations;
using Chris.Api.Models;

namespace Chris.Api.ValidationAttributes
{
    public class EmployeeNoMustDifferentFromNameAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //作用于属性的话，返回属性；作用于类的话，返回对象
            var addDto = (EmployeeAddOrUpdateDto)validationContext.ObjectInstance;

            if (addDto.EmployeeNo == addDto.FirstName)
            {
                return new ValidationResult(ErrorMessage,
                    new[] { nameof(EmployeeAddOrUpdateDto) });
            }

            return ValidationResult.Success;
        }
    }
}
