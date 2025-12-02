using Internship_4_OOP2.Domain.Common.Validation;

namespace Internship_4_OOP2.Application.Common.Model
{
    public class Result<TValue> where TValue : class
    {
        private List<ValidationResultItem> _info = new List<ValidationResultItem>();
        private List<ValidationResultItem> _warnings = new List<ValidationResultItem>();
        private List<ValidationResultItem> _errors = new List<ValidationResultItem>();

        public TValue? Value { get; set; }
        public Guid RequestId { get; set; }
        public bool isAuthorized { get; set; } = true;

        public IReadOnlyList<ValidationResultItem> Infos
        {
            get => _info.AsReadOnly();
            init => _info.AddRange(value);
        }

        public IReadOnlyList<ValidationResultItem> Errors
        {
            get => _errors.AsReadOnly();
            init => _errors.AddRange(value);
        }

        public IReadOnlyList<ValidationResultItem> Warnings
        {
            get => _warnings.AsReadOnly();
            init => _warnings.AddRange(value);
        }

        public bool HasError => Errors.All(validationResult => validationResult.ValidationSeverity == Domain.Common.Validation.ValidationSeverity.Error);
        public bool HasInfo => Infos.All(validationResult => validationResult.ValidationSeverity == Domain.Common.Validation.ValidationSeverity.Info);
        public bool HasWarning => Warnings.All(validationResult => validationResult.ValidationSeverity == Domain.Common.Validation.ValidationSeverity.Warning);


        public void SetResult(TValue value)
        {
            Value = Value;
        }


        public void SetValidationResult(ValidationResult validationResult)
        {
            _errors?.AddRange(validationResult.ValidationItems.Where(x => x.ValidationSeverity == ValidationSeverity.Error).Select(x => ValidationResultItem.FormValidationItem(x)));
        }

        public void SetUnauthorizedResult()
        {
            Value = null;
            isAuthorized = false;
        }
    }
}
