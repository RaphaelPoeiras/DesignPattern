namespace DesignPatterns.Structural.Facade.SubSistema
{
    public class Serasa
    {
        public bool DividasAtivas(Cliente cliente)
        {
            Console.WriteLine($"Cliente não possuí dividas ativas no Serasa: {cliente.Nome}");
            return false;
        }
    }
}