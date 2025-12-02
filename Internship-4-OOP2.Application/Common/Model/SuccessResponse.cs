namespace Internship_4_OOP2.Application.Common.Model
{
    public class SuccessResponse
    {
        public bool IsSuccess { get; init; }

        public SuccessResponse()
        {

        }

        public SuccessResponse(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }
    }
}
