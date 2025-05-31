namespace C1DOMAIN.Entities
{
    public class Cliente
    {
        public Cliente() { }
        // método 1
        public Cliente(string nome, Guid clienteId)
        {
            Nome = nome;
            ClienteId = clienteId;
        }

        public Guid ClienteId { get; private set; }
        // método 2
        public void AlterarId(Guid clienteId)
        {
            ClienteId = clienteId;
        }

        public string? Nome { get; private set; }
        public void AlterarNome(string? nome)
        {
            Nome = nome;
        }
    }
}
