namespace Internship_4_OOP2.Domain.Common.Model
{
    public class GetAllResponse<TValue>
    {
        public IEnumerable<TValue> Values { get; init; } 
    }
}
