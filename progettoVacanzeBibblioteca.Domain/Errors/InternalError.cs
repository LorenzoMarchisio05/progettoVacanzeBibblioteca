namespace progettoVacanzeBibblioteca.Domain.Errors
{
    public sealed class InternalError : BaseError
    {
        private InternalError(string message) : base(message)
        {
        }

        public static InternalError Create(string message) => new InternalError(message);
    }
}