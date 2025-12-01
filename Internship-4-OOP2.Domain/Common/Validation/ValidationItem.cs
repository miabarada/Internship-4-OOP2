namespace Internship_4_OOP2.Domain.Common.Validation
{
    public class ValidationItem
    {
        public ValidationType ValidationType { get; init; }
        public ValidationSeverity ValidationSeverity { get; init; }
        public string Code { get; init; }
        public string Message { get; init; }
    }
}
