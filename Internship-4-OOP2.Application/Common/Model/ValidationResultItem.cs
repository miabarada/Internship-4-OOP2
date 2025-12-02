using Internship_4_OOP2.Domain.Common.Validation;

namespace Internship_4_OOP2.Application.Common.Model
{
    public class ValidationResultItem
    {
        public ValidationSeverity ValidationSeverity { get; init; }
        public ValidationType ValidationType { get; init; }
        public string Code { get; set; }
        public string Message { get; set; }

        public static ValidationResultItem FormValidationItem(ValidationItem item)
        {
            return new ValidationResultItem
            {
                ValidationSeverity = item.ValidationSeverity,
                ValidationType = item.ValidationType,
                Code = item.Code,
                Message = item.Message
            };
        }
    }
}
