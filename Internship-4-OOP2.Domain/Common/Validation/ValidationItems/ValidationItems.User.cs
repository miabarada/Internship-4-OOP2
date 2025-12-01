namespace Internship_4_OOP2.Domain.Common.Validation.ValidationItems
{
    public static partial class ValidationItems
    {
        public static class User
        {
            public static string CodePrefix = nameof(User);

            public static readonly ValidationItem NameMaxLength = new ValidationItem
            {
                Code = $"{CodePrefix}",
                Message = $"Ime ne smije biti duže od {Entities.Users.User.NameMaxLength} znakova",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem AddressStreetMaxLength = new ValidationItem
            {
                Code = $"{CodePrefix}",
                Message = $"Ime ulice ne smije biti duže od {Entities.Users.User.AddressStreetMaxLength} znakova",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem AddressCityMaxLength = new ValidationItem
            {
                Code = $"{CodePrefix}",
                Message = $"Ime grada ne smije biti duže od {Entities.Users.User.AddressCityMaxLength} znakova",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };

            public static readonly ValidationItem WebsiteMaxLength = new ValidationItem
            {
                Code = $"{CodePrefix}",
                Message = $"Ime grada ne smije biti duže od {Entities.Users.User.WebsiteMaxLength} znakova",
                ValidationSeverity = ValidationSeverity.Error,
                ValidationType = ValidationType.FormalValidation
            };
        }
    }
}
