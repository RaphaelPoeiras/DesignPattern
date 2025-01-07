namespace DesignPatterns.Structural.Facade.SubSistema
{
    public class Cadastro
    {
        public void CadastrarCliente(Cliente cliente)
        {
            Console.WriteLine($"Cadastro de cliente {cliente.Nome} realizado com sucesso");
        }
    }
}