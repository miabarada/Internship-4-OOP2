using System.Text.Json.Serialization;

namespace Internship_4_OOP2.Domain.Common.Validation
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ValidationSeverity
    {
        Warning, 
        Error, 
        Info
    }
}
