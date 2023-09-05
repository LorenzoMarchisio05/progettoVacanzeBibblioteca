namespace progettoVacanzeBibblioteca.Domain.Entities
{
    public sealed class PhoneNumber
    {
        private string Value { get; }

        private PhoneNumber(string number)
        {
            Value = number;
        }

        public static PhoneNumber From(string number) => new PhoneNumber(number);

        public static implicit operator string(PhoneNumber number) => number.ToString();
        public override string ToString() => Value ?? "";
    }
}