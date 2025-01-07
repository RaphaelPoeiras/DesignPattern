namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class GerenteProjeto : Autorizador
    {
        private int diasMaximoAprovacao = 5;
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
            Console.WriteLine($"O Gerente de projetos aprovou {dias} de licença para o {nome}");
        }
    }
}