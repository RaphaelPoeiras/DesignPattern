namespace DesignPatterns.Structural.Bridge
{
    public class ExecutorBridge
    {
        public void Execute()
        {
            Mensagem email = new MensagemNormal(new EnviaEmail());
            email.EnviaMensagem();

            Mensagem mensagem = new MensagemAnexo(new EnviaSms());
            mensagem.EnviaMensagem();
        }
    }
}