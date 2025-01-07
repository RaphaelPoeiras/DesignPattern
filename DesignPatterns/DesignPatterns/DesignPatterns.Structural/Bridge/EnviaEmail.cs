namespace DesignPatterns.Structural.Bridge
{
    public class EnviaEmail : IDespachaMensagem
    {
        public void EnviarMensagem()
        {
            Console.WriteLine("Email Enviado");
        }
    }
}