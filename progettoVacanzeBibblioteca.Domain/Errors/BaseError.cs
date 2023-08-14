namespace progettoVacanzeBibblioteca.Domain.Errors
{
    public class BaseError
    {
        public string Message { get; }

        protected BaseError(string message)
        {
            Message = message;
        }

        public override string ToString() => $"{this.GetType().Name}: {Message}";
    }
}