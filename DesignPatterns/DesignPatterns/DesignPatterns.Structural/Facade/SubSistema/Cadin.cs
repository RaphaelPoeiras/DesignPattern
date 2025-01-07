namespace DesignPatterns.Structural.Facade.SubSistema
{
    public class Cadin
    {
        public bool DividasAtivasCadin(Cliente cliente)
        {
            Console.WriteLine($"Cliente não possuí dívidas ativas no Cadin: {cliente.Nome}");
            return false;
        }
    }
}