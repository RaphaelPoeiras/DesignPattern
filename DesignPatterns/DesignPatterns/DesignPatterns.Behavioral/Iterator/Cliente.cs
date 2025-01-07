namespace DesignPatterns.Behavioral.Iterator
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Cliente(string nome, int id)
        {
            Id = id;
            Nome = nome;
        }
    }
}