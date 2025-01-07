namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class RH : Autorizador
    {
        private int diasMaximoAprovacao = 25;
        public override void AutorizarLicenca(string nome, int dias)
        {
            if (dias <= diasMaximoAprovacao)
            {
                AprovarLicenca(nome, dias);
            }
            else
            {
                Console.WriteLine($"Não foi possível aprovar a licença");
            }
        }

        private void AprovarLicenca(string nome, int dias)
        {
            Console.WriteLine($"O Supervisor aprovou {dias} de licença para o {nome}");
        }
    }
}