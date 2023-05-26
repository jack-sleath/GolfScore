namespace GolfScore.API
{
    public static class ResultStatus
    {
        public const int Success = 200;
        public const int Created = 201;
        public const int FailedValidation = 400;
        public const int UnexpectedError = 500;
    }
}
