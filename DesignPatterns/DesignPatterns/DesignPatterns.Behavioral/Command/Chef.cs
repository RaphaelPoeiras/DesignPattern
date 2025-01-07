namespace DesignPatterns.Behavioral.Command
{
    public class Chef
    {
        public void PreparandoPrato()
        {
            Console.WriteLine($"Chef está preparando o prato");
        }

        public void PreparandoSobremesa()
        {
            Console.WriteLine($"Chef está preparando a sobremesa");
        }
    }
}