namespace progettoVacanzeBibblioteca.Domain.Entities
{
    public sealed class Socio
    {
        public long Id { get; }

        public string Cognome { get; }

        public string Nome { get; }

        public PhoneNumber Telefono { get; }

        public Email Email { get; }

        public Socio(long id, string cognome, string nome, PhoneNumber telefono, Email email)
        {
            Id = id;
            Cognome = cognome;
            Nome = nome;
            Telefono = telefono;
            Email = email;
        }

        public override string ToString() => 
            $"{nameof(Id)}:{Id} " +
            $"{nameof(Cognome)}:{Cognome} " +
            $"{nameof(Nome)}:{Nome} " +
            $"{nameof(Telefono)}:{Telefono} " +
            $"{nameof(Email)}:{Email}";
    }
}