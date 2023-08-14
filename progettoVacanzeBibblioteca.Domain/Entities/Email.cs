namespace progettoVacanzeBibblioteca.Domain.Entities
{
    public sealed class Email
    {
        public string Value { get; }

        private Email(string email)
        {
            Value = email;
        }

        public static Email From(string email) => new Email(email);

        public static implicit operator string(Email email) => email.ToString();
        public override string ToString() => Value;
    }
}