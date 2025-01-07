namespace DesignPatterns.Structural.Bridge
{
    public class MensagemNormal : Mensagem
    {
        public MensagemNormal(IDespachaMensagem enviarMensagem) : base(enviarMensagem) { }
        public override void MontarMensagem()
        {
            Console.WriteLine("Mensagem normal");
        }
    }
}