namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Supervisor : Autorizador
    {
        private int diasMaximoAprovacao = 15;
        public override void AutorizarLicenca(string nome, int dias)
        {
            if (dias <= diasMaximoAprovacao)
            {
                AprovarLicenca(nome, dias);
            }
            else
            {
                _autorizador?.AutorizarLicenca(nome, dias);
            }
        }

        private void AprovarLicenca(string nome, int dias)
        {
            Console.WriteLine($"O Supervisor aprovou {dias} de licença para o {nome}");
        }
    }
}